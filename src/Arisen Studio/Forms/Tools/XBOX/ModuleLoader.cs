using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Humanizer;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Resources;
using System.Windows.Forms;
using XDevkit;
using JRPC_Client;

namespace ArisenStudio.Forms.Tools.XBOX
{
    public partial class ModuleLoader : XtraForm
    {
        public ModuleLoader()
        {
            InitializeComponent();
        }

        public static ResourceManager Language = MainWindow.ResourceLanguage;

        public static SettingsData Settings = MainWindow.Settings;

        public static IXboxConsole XboxConsole { get; } = MainWindow.XboxConsole;

        private static IXboxDebugTarget DebugTarget { get; set; } = XboxConsole.DebugTarget;

        private IXboxModule SelectedModule { get; set; } = null;

        private void ModuleLoader_Load(object sender, EventArgs e)
        {
            Text = Language.GetString("MODULES_LOADER");

            ButtonRefreshModules.Text = Language.GetString("LABEL_LOAD_MODULE");
            ButtonUnloadModule.Text = Language.GetString("LABEL_UNLOAD_MODULE");

            DebugTarget.ConnectAsDebugger(XboxConsole.IPAddress.ToString(), XboxDebugConnectFlags.Force);

            LoadModules();
        }

        private DataTable Modules { get; } = DataExtensions.CreateDataTable(new List<DataColumn>
        {
            //new("Module Path", typeof(string)),
            new(Language.GetString("LABEL_NAME"), typeof(string)),
            new(Language.GetString("LABEL_SIZE"), typeof(string))
        });

        private void LoadModules()
        {
            try
            {
                GridBootModules.DataSource = null;

                foreach (IXboxModule module in DebugTarget.Modules)
                {
                    Modules.Rows.Add(module.ModuleInfo.Name, Settings.UseFormattedFileSizes ? module.ModuleInfo.Size.Bytes().Humanize("#.##") : module.ModuleInfo.Size + " " + Language.GetString("LABEL_BYTES"));
                }

                GridBootModules.DataSource = Modules;

                //GridViewModules.Columns[0].Width = 258;
                GridViewModules.Columns[1].Width = 100;
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, $"Unable to load modules. Error: {ex.Message}");
                XtraMessageBox.Show(this, $"Unable to load modules.\n\nError: {ex.Message}", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void GridViewModules_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (GridViewModules.SelectedRowsCount > 0)
            {
                SelectedModule = XboxConsole.DebugTarget.Modules[e.FocusedRowHandle];
                ButtonUnloadModule.Enabled = true;
            }
        }

        private void GridViewModules_RowClick(object sender, RowClickEventArgs e)
        {
            if (GridViewModules.SelectedRowsCount > 0)
            {
                SelectedModule = XboxConsole.DebugTarget.Modules[e.RowHandle];
                ButtonUnloadModule.Enabled = true;
            }
        }

        private void ButtonInjectPlugin_Click(object sender, EventArgs e)
        {
            try
            {
                object[] arguments = new object[] { ComboBoxDrives.Text + TextBoxModuleName.Text, 8, 0, 0 };
                XboxExtensions.Call<uint>(XboxConsole, "xboxkrnl.exe", 0x199, arguments);

                //XboxExtensions.Call<uint>(XboxConsole, "xboxkrnl.exe", 409, new object[] { moduleName, 8, 0, 0 });

                Program.Log.Info("Module {0} has been loaded.", ComboBoxDrives.Text + TextBoxModuleName.Text);
                XtraMessageBox.Show(this, Language.GetString("MODULE_LOAD_SUCCESS"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "Unable to unload module.");
                XtraMessageBox.Show(this, string.Format(Language.GetString("MODULE_LOAD_ERROR"), ex.Message), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonUnloadModule_Click(object sender, EventArgs e)
        {
            UnloadModule(SelectedModule.ModuleInfo.Name, true);
            //XtraMessageBox.Show(this, Language.GetString("MODULE_LOAD_SUCCESS"), Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonRefreshModules_Click(object sender, EventArgs e)
        {
            LoadModules();
            //XtraMessageBox.Show(this, Language.GetString("MODULE_LOAD_SUCCESS"), Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UnloadModule(string module, bool sysdll)
        {
            try
            {
                uint moduleHandle = GetModuleHandle(module);

                if (moduleHandle != 0)
                {
                    if (sysdll)
                    {
                        XboxExtensions.WriteInt16(XboxConsole, moduleHandle + 0x40, 1);
                    }

                    object[] arguments = new object[] { moduleHandle };
                    XboxConsole.CallVoid("xboxkrnl.exe", 0x1a1, arguments);

                    LoadModules();

                    Program.Log.Info("Module has been unloaded.");
                    XtraMessageBox.Show(this, Language.GetString("MODULE_UNLOAD_SUCCESS"), Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Program.Log.Error("Unable to unload module.");
                    XtraMessageBox.Show(this, Language.GetString("MODULE_UNLOAD_ERROR"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "Unable to unload module.");
                XtraMessageBox.Show(this, string.Format(Language.GetString("MODULE_UNLOAD_ERROR"), ex.Message), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private uint GetModuleHandle(string moduleName)
        {
            object[] arguments = new object[] { moduleName };
            return XboxExtensions.Call<uint>(XboxConsole, "xam.xex", 0x44e, arguments);
        }
    }
}