using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NeoModsX.Extensions;
using NeoModsX.Forms.Windows;
using NeoModsX.Models.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Resources;
using System.Windows.Forms;
using XDevkit;

namespace NeoModsX.Forms.Tools.XBOX
{
    public partial class ModuleLoader : XtraForm
    {
        public ModuleLoader()
        {
            InitializeComponent();
        }

        public static ResourceManager Language = MainWindow.ResourceLanguage;

        public static SettingsData Settings = MainWindow.Settings;

        public static IXboxConsole XboxConsole = MainWindow.XboxConsole;

        delegate void ModuleCallBack(string moduleName);

        //static void Show(string moduleName)
        //{
        //    ModuleLoader.ShowModuleNames();
        //}

        //static void Load(string moduleName)
        //{
        //    ModuleLoader.LoadModule(moduleName);
        //}

        //static void Unload(string moduleName)
        //{
        //    ModuleLoader.UnloadModule(moduleName);
        //}

        //static void UnloadThenLoad(string moduleName)
        //{
        //    if (ModuleLoader.IsModuleLoaded(moduleName))
        //        ModuleLoader.UnloadModule(moduleName);

        //    ModuleLoader.LoadModule(moduleName);
        //}

        IXboxModule SelectedModule = null;

        private void ModuleLoader_Load(object sender, EventArgs e)
        {
            Text = Language.GetString("MODULE_LOADER");

            ButtonLoadModule.Text = Language.GetString("LABEL_LOAD_MODULE");
            ButtonUnloadModule.Text = Language.GetString("LABEL_UNLOAD_MODULE");

            LoadModules();
        }

        private DataTable Modules { get; } = DataExtensions.CreateDataTable(new List<DataColumn>
        {
            new("Module Path", typeof(string)),
            new(Language.GetString("LABEL_NAME"), typeof(string)),
            new(Language.GetString("LABEL_SIZE"), typeof(string))
        });

        private void LoadModules()
        {
            try
            {
                GridBootModules.DataSource = null;

                foreach (IXboxModule module in XboxConsole.DebugTarget.Modules)
                {
                    Modules.Rows.Add(module.ModuleInfo.FullName);
                    Modules.Rows.Add(module.ModuleInfo.Name);
                    Modules.Rows.Add(module.ModuleInfo.Size);
                }

                GridBootModules.DataSource = Modules;

                GridViewModules.Columns[0].Visible = false;
                //GridViewModules.Columns[1].Width = 258;
                GridViewModules.Columns[2].Width = 100;

                //GridViewBootPlugins.AutoFillColumn = GridViewBootPlugins.Columns[0];
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
                ButtonLoadModule.Enabled = true;
                ButtonUnloadModule.Enabled = true;
            }
        }

        private void GridViewModules_RowClick(object sender, RowClickEventArgs e)
        {
            if (GridViewModules.SelectedRowsCount > 0)
            {
                SelectedModule = XboxConsole.DebugTarget.Modules[e.RowHandle];
                ButtonLoadModule.Enabled = true;
                ButtonUnloadModule.Enabled = true;
            }
        }

        private void ButtonLoadModule_Click(object sender, EventArgs e)
        {
            LoadModule(SelectedModule.ModuleInfo.FullName);
            //XtraMessageBox.Show(this, Language.GetString("MODULE_LOAD_SUCCESS"), Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonUnloadModule_Click(object sender, EventArgs e)
        {
            UnloadModule(SelectedModule.ModuleInfo.FullName);
            //XtraMessageBox.Show(this, Language.GetString("MODULE_LOAD_SUCCESS"), Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static List<string> GetModuleNames()
        {
            List<string> moduleNames = new();

            foreach (IXboxModule module in XboxConsole.DebugTarget.Modules)
            {
                moduleNames.Add(module.ModuleInfo.Name);
            }

            return moduleNames;
        }

        public void LoadModule(string moduleName)
        {
            if (moduleName.Contains("\\") == false)
            {
                moduleName = "Hdd:\\" + moduleName;
            }

            if (!FileExists(moduleName))
            {
                return;
            }

            if (IsModuleLoaded(moduleName))
            {
                Program.Log.Error("Module is already loaded.");
                XtraMessageBox.Show(this, Language.GetString("MODULE_LOADED"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                XboxExtensions.Call<uint>(XboxConsole, "xboxkrnl.exe", 409, new object[] { moduleName, 8, 0, 0 });
                Program.Log.Info("Module has been loaded.");
                XtraMessageBox.Show(this, Language.GetString("MODULE_LOAD_SUCCESS"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "Unable to unload module.");
                XtraMessageBox.Show(this, string.Format(Language.GetString("MODULE_LOAD_ERROR"), ex.Message), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UnloadModule(string moduleName)
        {
            if (!FileExists(moduleName))
            {
                return;
            }

            if (!IsModuleLoaded(moduleName))
            {
                Program.Log.Error("Module is not loaded.");
                XtraMessageBox.Show(this, Language.GetString("MODULE_NOT_LOADED"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                uint handle = XboxExtensions.Call<uint>(XboxConsole, "xam.xex", 1102, new object[] { moduleName });

                if (handle != 0u)
                {
                    XboxExtensions.WriteShort(XboxConsole, handle + 0x40, 1);
                    XboxExtensions.Call<uint>(XboxConsole, "xboxkrnl.exe", 417, new object[] { handle });
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

        public bool IsModuleLoaded(string moduleName)
        {
            try
            {
                List<string> modules = GetModuleNames();

                foreach (string module in modules)
                {
                    if (moduleName.Contains(module))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }

            return false;
        }

        public bool FileExists(string filePath)
        {
            try
            {
                IXboxFile file = XboxConsole.GetFileObject(filePath);
                return true;
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "File doesn't exist.");
                return false;
            }
        }
    }
}