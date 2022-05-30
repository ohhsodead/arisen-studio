using DevExpress.XtraEditors;
using NeoModsX.Forms.Windows;
using NeoModsX.Models.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NeoModsX.Controls
{
    public partial class ProfileItem : XtraUserControl, IMessageFilter
    {
        public ProfileItem(string consoleName, Image image)
        {
            InitializeComponent();
            ImageConsole.Image = image;
            LabelConsoleName.Text = consoleName;
            ConsoleImage = image;
            Application.AddMessageFilter(this);
        }

        public void ReloadControls()
        {
            ImageConsole.Image = ConsoleImage;
            LabelConsoleName.Text = ConsoleProfile.Name;
        }

        public Image ConsoleImage { get; set; }

        public ConsoleProfile ConsoleProfile { get; set; }

        public bool IsSelected { get; set; }

        public bool ShouldHover { get; set; } = true;

        public bool PreFilterMessage(ref Message m)
        {
            if (ShouldHover)
            {
                switch (IsDisposed)
                {
                    case false when ClientRectangle.Contains(PointToClient(MousePosition)):
                        BackColor = MainWindow.SkinColors.GetColor("Highlight");
                        break;
                    default:
                        {
                            BackColor = IsSelected switch
                            {
                                false => Color.Transparent,
                                _ => BackColor
                            };

                            break;
                        }
                }
            }

            return false;
        }

        public new event EventHandler OnClick
        {
            add
            {
                Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += value;
                }
            }
            remove
            {
                Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= value;
                }
            }
        }

        public new event EventHandler OnDoubleClick
        {
            add
            {
                DoubleClick += value;
                foreach (Control control in Controls)
                {
                    control.DoubleClick += value;
                }
            }
            remove
            {
                DoubleClick -= value;
                foreach (Control control in Controls)
                {
                    control.DoubleClick -= value;
                }
            }
        }
    }
}