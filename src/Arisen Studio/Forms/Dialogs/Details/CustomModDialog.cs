using DevExpress.Utils;
using DevExpress.XtraEditors;
using Humanizer;
using ArisenStudio.Controls;
using ArisenStudio.Database;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Database;
using ArisenStudio.Models.Resources;
using ArisenStudio.Templates;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using ScrollOrientation = DevExpress.XtraEditors.ScrollOrientation;
using System.Text.RegularExpressions;
using System.Drawing;

namespace ArisenStudio.Forms.Dialogs.Details
{
    public partial class CustomModDialog : XtraForm
    {
        public CustomModDialog()
        {
            InitializeComponent();
        }

        public static SettingsData Settings = MainWindow.Settings;
        public static ConsoleProfile ConsoleProfile = MainWindow.ConsoleProfile;
        public static ResourceManager Language = MainWindow.ResourceLanguage;
        public static CategoriesData Categories = MainWindow.Database.CategoriesData;

        public CustomItemData CustomItem;

        public InstalledModInfo InstalledModInfo;

        private void CustomModDialog_Load(object sender, EventArgs e)
        {
            Region = new Region(GraphicExtensions.GetRoundedRectanglePath(ClientRectangle, 20));

            InstalledModInfo = MainWindow.ConsoleProfile != null ? MainWindow.Settings.GetInstalledMods(ConsoleProfile, CustomItem.Category, CustomItem.Id, true) : null;

            LabelCategoryType.Text = CustomItem.CategoryType.Humanize();
            LabelCategory.Text = CustomItem.Category;
            LabelName.Text = CustomItem.Name.Replace("&", "&&");

            StatPlatform.Title = Language.GetString("LABEL_SYSTEM_TYPE");
            StatModType.Title = Language.GetString("LABEL_MOD_TYPE");
            StatVersion.Title = Language.GetString("LABEL_VERSION");
            StatCreatedBy.Title = Language.GetString("LABEL_CREATED_BY");

            StatPlatform.Value = CustomItem.Platform.Humanize();
            StatModType.Value = CustomItem.ModType;
            StatVersion.Value = CustomItem.Version;
            //StatCreatedBy.Value = CustomItem.CreatedBy;

            TabDescription.Text = Language.GetString("LABEL_DESCRIPTION");
            TabInstallationFiles.Text = $"{Language.GetString("LABEL_INSTALLATION_FILES")} ({CustomItem.Files.Count()})";

            LabelDescription.Text = string.IsNullOrWhiteSpace(CustomItem.Description)
                ? Language.GetString("NO_MORE_DETAILS")
                : CustomItem.Description.Replace("&", "&&");

            ButtonInstall.Text = Language.GetString("LABEL_INSTALL");
            ButtonEditDetails.Text = Language.GetString("LABEL_EDIT");

            if (!MainWindow.IsConsoleConnected && !MainWindow.Settings.InstallHomebrewToUsbDevice)
            {
                ButtonInstall.Enabled = false;
            }

            int count = 0;
            foreach (ListItem installFile in CustomItem.Files)
            {
                count++;

                CustomFileItem customFileItem = new()
                {
                    CustomModItem = CustomItem,
                    InstallFile = installFile
                };

                if (CustomItem.Files.Count() > 1 && count != 1)
                {
                    customFileItem.ShowSeparator = true;
                }

                customFileItem.Dock = DockStyle.Top;
                TabInstallationFiles.Controls.Add(customFileItem);
            }
        }

        private void ImageClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TabDescription_Scroll(object sender, XtraScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                TabDescription.VerticalScroll.Value = e.NewValue;
            }
        }

        private void TabDownloads_Scroll(object sender, XtraScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                TabInstallationFiles.VerticalScroll.Value = e.NewValue;
            }
        }

        private void LabelDescription_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            _ = Process.Start(e.Link);
        }

        private void ButtonInstallMod_Click(object sender, EventArgs e)
        {
            if (InstalledModInfo == null)
            {
                DialogExtensions.ShowTransferFilesDialog(this, TransferType.InstallCustom, CustomItem);
            }
            else
            {
                DialogExtensions.ShowTransferFilesDialog(this, TransferType.UninstallCustom, CustomItem);
            }
        }

        private void ButtonEditDetails_Click(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using Pen pen = new(Color.Transparent, 0);
            e.Graphics.DrawPath(pen, GraphicExtensions.GetRoundedRectanglePath(ClientRectangle, 4));
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using Brush brush = new SolidBrush(BackColor);
            e.Graphics.FillPath(brush, GraphicExtensions.GetRoundedRectanglePath(ClientRectangle, 4));
        }

        private const int WmHscroll = 0x114;
        private const int WmVscroll = 0x115;

        protected override void WndProc(ref Message m)
        {
            if ((m.Msg == WmHscroll || m.Msg == WmVscroll)
            && (((int)m.WParam & 0xFFFF) == 5))
            {
                // Change SB_THUMBTRACK to SB_THUMBPOSITION
                m.WParam = (IntPtr)(((int)m.WParam & ~0xFFFF) | 4);
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }
    }
}