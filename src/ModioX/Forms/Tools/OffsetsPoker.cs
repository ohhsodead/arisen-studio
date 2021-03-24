using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ModioX.Database;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Models.Database;
using ModioX.Models.Resources;
using PS3Lib;
using XDevkit;

namespace ModioX.Forms.Tools
{
    public partial class OffsetsPoker : XtraForm
    {
        public OffsetsPoker()
        {
            InitializeComponent();
        }

        private CategoriesData Categories { get; } = MainWindow.Database.CategoriesData;

        private OffsetsData ModsOffsets { get; set; } = MainWindow.Database.ModsOffsets;

        private PS3API PS3 { get; set; } = new PS3API(SelectAPI.ControlConsole);

        private IXboxConsole XBOX { get; set; } = null;

        private bool IsConsoleConnected { get; set; } = false;

        private ConsoleTypePrefix ConsoleType { get; set; } = MainWindow.ConsoleType;

        private string SelectedGameId { get; set; } = "";

        private string SelectedGameMode { get; set; } = "";

        private string SelectedCategory { get; set; } = "";

        private void OffsetsPoker_Load(object sender, EventArgs e)
        {

        }

        private void TimerWait_Tick(object sender, EventArgs e)
        {
            ComboBoxGameTitles.Properties.Items.Clear();
            ComboBoxCategory.Properties.Items.Clear();
            ComboBoxCategory.Properties.Items.Add("ALL");

            foreach (Category category in Categories.GetCategoriesByType(CategoryType.Game))
            {
                var mods = ModsOffsets.GetModsByConsoleTypeAndGameId(ConsoleType.ToString(), category.Id);

                if (mods.Count > 0)
                {
                    ComboBoxGameTitles.Properties.Items.Add(category.Title);
                }

                foreach (var mod in mods)
                {
                    foreach (var offset in mod.Memory)
                    {
                        if (offset.Category.ContainsIgnoreCase(SelectedCategory) && !ComboBoxCategory.Properties.Items.Contains(offset.Category))
                        {
                            ComboBoxCategory.Properties.Items.Add(offset.Category);
                        }
                    }
                }
            }

            ComboBoxGameTitles.SelectedIndex = 0;
            ComboBoxCategory.SelectedIndex = 0;
            ComboBoxGameMode.SelectedIndex = 0;

            TimerWait.Enabled = false;
        }

        private void ButtonConnectToPS3_ItemClick(object sender, ItemClickEventArgs e)
        {
            ConnectToPS3();

            GroupGameMods.Text = "Game Mods (PS3)";
        }

        private void MenuItemDisconnectPS3_ItemClick(object sender, ItemClickEventArgs e)
        {
            DisconnectFromPS3();
        }

        private void MenuItemConnectToXBOX_ItemClick(object sender, ItemClickEventArgs e)
        {
            ConnectToXBOX();

            GroupGameMods.Text = "Game Mods (XBOX)";
        }

        private void MenuItemDisconnectXBOX_ItemClick(object sender, ItemClickEventArgs e)
        {
            DisconnectFromXBOX();
        }

        private void ConnectToPS3()
        {
            try
            {
                if (PS3.ConnectTarget())
                {
                    if (PS3.AttachProcess())
                    {
                        IsConsoleConnected = true;

                        SetStatusConsole(PS3.GetConsoleName());
                        ConsoleType = ConsoleTypePrefix.PS3;
                        EnableConsoleActions();

                        MenuItemConnectToPS3.Visibility = BarItemVisibility.Never;
                        MenuItemDisconnectPS3.Visibility = BarItemVisibility.Always;

                        MenuItemConnectXBOX.Enabled = false;

                        XtraMessageBox.Show(this, $"Connected and attached to console.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show(this, "Unable to attach to game process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show(this, "Unable to connect to console.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "Unable to connect to console.\n\nError Message:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Disconnect from PS3 console.
        /// </summary>
        private void DisconnectFromPS3()
        {
            try
            {
                PS3.DisconnectTarget();

                IsConsoleConnected = false;

                SetStatusConsole(null);
                EnableConsoleActions();

                MenuItemConnectToPS3.Visibility = BarItemVisibility.Always;
                MenuItemDisconnectPS3.Visibility = BarItemVisibility.Never;

                MenuItemConnectXBOX.Enabled = true;

                SetStatus("Successfully disconnected from console.");
                XtraMessageBox.Show(this, "Successfully disconnected from console", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SetStatus("Unable to disconnect from console - Error: " + ex.Message, ex);
                XtraMessageBox.Show(this, "Unable to disconnect from console.\n\nError Message:\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void ConnectToXBOX()
        {
            try
            {
                XBOX = MainWindow.XboxConsole;
                IsConsoleConnected = true;

                SetStatusConsole(PS3.GetConsoleName());
                ConsoleType = ConsoleTypePrefix.XBOX;
                EnableConsoleActions();

                MenuItemConnectToXBOX.Visibility = BarItemVisibility.Never;
                MenuItemDisconnectXBOX.Visibility = BarItemVisibility.Always;

                MenuItemConnectPS3.Enabled = false;

                XtraMessageBox.Show(this, $"Connected and attached to console.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "Unable to connect to console.\n\nError Message:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void DisconnectFromXBOX()
        {
            try
            {
                PS3.DisconnectTarget();

                IsConsoleConnected = false;

                SetStatusConsole(null);
                EnableConsoleActions();

                MenuItemConnectToXBOX.Visibility = BarItemVisibility.Always;
                MenuItemDisconnectXBOX.Visibility = BarItemVisibility.Never;

                MenuItemConnectPS3.Enabled = true;

                SetStatus("Successfully disconnected from console.");
                XtraMessageBox.Show(this, "Successfully disconnected from console", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SetStatus("Unable to disconnect from console - Error: " + ex.Message, ex);
                XtraMessageBox.Show(this, "Unable to disconnect from console.\n\nError Message:\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxGameTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGameTitles.SelectedIndex != -1)
            {
                SelectedGameId = Categories.GetCategoryByTitle(ComboBoxGameTitles.SelectedItem.ToString()).Id;
                LoadGameMods();
            }
        }

        private void ComboBoxGameMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGameMode.SelectedIndex != -1)
            {
                if (ComboBoxGameMode.SelectedIndex == 0)
                {
                    SelectedGameMode = string.Empty;
                    LoadGameMods();
                    return;
                }

                SelectedGameMode = ComboBoxGameMode.SelectedItem.ToString();
                LoadGameMods();
            }
        }

        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxCategory.SelectedIndex != -1)
            {
                if (ComboBoxCategory.SelectedIndex == 0)
                {
                    SelectedCategory = string.Empty;
                    LoadGameMods();
                    return;
                }

                SelectedCategory = ComboBoxCategory.SelectedItem.ToString();
                LoadGameMods();
            }
        }

        private void LoadGameMods()
        {
            GridModsOffsets.DataSource = null;

            var dataTable = DataExtensions.CreateDataTable(new List<DataColumn>() { new DataColumn("Console Type"), new DataColumn("Toggleable"), new DataColumn("Name"), new DataColumn("Game Mode"), new DataColumn("Category") });
            
            foreach (ModsOffsets modsOffsets in ModsOffsets.GetMods(ConsoleType.ToString(), SelectedGameId, SelectedGameMode, SelectedCategory))
            {
                foreach (Memory memory in modsOffsets.Memory)
                {
                    dataTable.Rows.Add(modsOffsets.ConsoleType, memory.Toggleable.ToString(), memory.Name, memory.GameMode, memory.Category);
                }
            }

            ProgressNoModsFound.Visible = dataTable.Rows.Count == 0;
            GridModsOffsets.DataSource = dataTable;

            GridViewModsOffsets.Columns[0].Visible = false;
            GridViewModsOffsets.Columns[1].Visible = false;
            GridViewModsOffsets.Columns[2].Width = 250;
            GridViewModsOffsets.Columns[3].Width = 75;

            if (dataTable.Rows.Count < 1)
            {
                MessageBox.Show("Game Id: " + SelectedGameId + "\nGame Mode: " + SelectedGameMode + "\nCategory: " + SelectedCategory);
            }
        }

        private void GridViewPackageFiles_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            //ButtonDeletePackageFile.Enabled = GridViewModsOffsets.SelectedRowsCount > 0;
            //ButtonDownloadPackageFile.Enabled = GridViewModsOffsets.SelectedRowsCount > 0;

            if (GridViewModsOffsets.SelectedRowsCount > 0)
            {
                string toggleable = GridViewModsOffsets.GetRowCellValue(GridViewModsOffsets.FocusedRowHandle, GridViewModsOffsets.Columns[1]).ToString();
                string name = GridViewModsOffsets.GetRowCellValue(GridViewModsOffsets.FocusedRowHandle, GridViewModsOffsets.Columns[2]).ToString();

                ButtonSetValue.Enabled = true;
                ButtonEnable.Enabled = true;
                ButtonDisable.Enabled = true;

                if (bool.Parse(toggleable))
                {
                    ButtonSetValue.Visible = false;
                    ButtonEnable.Visible = true;
                    ButtonDisable.Visible = true;
                }
                else
                {
                    ButtonSetValue.Visible = true;
                    ButtonEnable.Visible = false;
                    ButtonDisable.Visible = false;
                }
            }
            else
            {
                ButtonSetValue.Enabled = false;
                ButtonEnable.Enabled = false;
                ButtonDisable.Enabled = false;
            }
        }

        private void GridViewPackageFiles_RowClick(object sender, RowClickEventArgs e)
        {
            //ButtonDeletePackageFile.Enabled = GridViewModsOffsets.SelectedRowsCount > 0;
            //ButtonDownloadPackageFile.Enabled = GridViewModsOffsets.SelectedRowsCount > 0;
            //XBOX.WriteBytes(123, Encoding.ASCII.GetBytes(""));
            //PS3.SetMemory(123, new byte[1]);
        }

        private void ButtonSetValue_Click(object sender, EventArgs e)
        {
            string name = GridViewModsOffsets.GetRowCellValue(GridViewModsOffsets.FocusedRowHandle, GridViewModsOffsets.Columns[2]).ToString();
            List<Offset> offsets = ModsOffsets.GetOffsetsByModName(ConsoleType.ToString(), SelectedGameId, name, SelectedGameMode);

            if (offsets == null)
            {
                MessageBox.Show("Can't find offsets.");
                SetStatus("Can't find offsets.");
            }
            else
            {
                foreach (var offset in offsets)
                {
                    //MessageBox.Show("Address: " + offset.Address + "\nValue:" + string.Join(", ", offset.Value.ToBytes()));
                    //MessageBox.Show(BitConverter.ToString(offset.Value.ToBytes()));

                    //var bytes = offset.Value.ToBytes();

                    //StringBuilder builder = new();
                    //for (int i = 0; i < bytes.Length; i++)
                    //{
                    //    builder.Append(bytes[i].ToString("X2"));
                    //}

                    //MessageBox.Show(builder.ToString());

                    if (offset.Value.IsNullOrEmpty())
                    {
                        if (offset.Type.Equals("string"))
                        {
                            var text = DialogExtensions.ShowTextInputDialog(this, $"Set {name}", "Value:");

                            if (text.IsNullOrWhiteSpace())
                            {
                                XtraMessageBox.Show("You must enter a value.", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            else
                            {
                                if (name.EqualsIgnoreCase("name"))
                                {
                                    WriteMemory(uint.Parse(offset.Address), Encoding.ASCII.GetBytes(text + '\0'));
                                }
                                else
                                {
                                    WriteMemory(uint.Parse(offset.Address), Encoding.ASCII.GetBytes(text));
                                }

                                SetStatus("New Value Set: " + name + " to " + text);
                            }
                        }
                        else if (offset.Type.Equals("int"))
                        {
                            var number = DialogExtensions.ShowNumberInputDialog(this, $"Set {name}", "Value:");

                            if (number.IsNullOrWhiteSpace())
                            {
                                XtraMessageBox.Show("You must enter a value.", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            else
                            {
                                WriteMemory(uint.Parse(offset.Address), BitConverter.GetBytes(Convert.ToInt32(number)));
                                SetStatus("New Value Set: " + name + " to " + number);
                            }
                        }
                        else if (offset.Type.Equals("hex"))
                        {
                            WriteMemory(uint.Parse(offset.Address), offset.Value.HexToBytes());
                            SetStatus("New Value Set.");
                        }
                    }
                    else
                    {
                        //WriteMemory(uint.Parse(offset.Address), Encoding.ASCII.GetBytes(offset.Value));
                        WriteMemory(uint.Parse(offset.Address), offset.Value.ToBytes());
                        SetStatus("New Value Set.");
                        System.Threading.Thread.Sleep(100);
                    }
                }

                //string source = "0x20, 0x64, 0x26, 0x00";

                //var result = source.GetBytes();

                //string test = string.Join(", ", result.Select(item => "0x" + item.ToString("x2")));

                //MessageBox.Show(test);

                //MessageBox.Show(BitConverter.ToString(result));
            }
        }

        private void ButtonEnable_Click(object sender, EventArgs e)
        {
            string name = GridViewModsOffsets.GetRowCellValue(GridViewModsOffsets.FocusedRowHandle, GridViewModsOffsets.Columns[2]).ToString();
            List<Offset> offsets = ModsOffsets.GetOffsetsByModName(ConsoleType.ToString(), SelectedGameId, name, SelectedGameMode);

            if (offsets == null)
            {
                SetStatus("Can't find offsets.");
            }
            else
            {
                foreach (var offset in offsets)
                {
                    if (offset.Type.Equals("hex"))
                    {
                        WriteMemory(uint.Parse(offset.Address), offset.Enable.HexToBytes());
                        System.Threading.Thread.Sleep(100);
                    }
                    else
                    {
                        WriteMemory(uint.Parse(offset.Address), offset.Enable.ToBytes());
                        System.Threading.Thread.Sleep(100);
                    }
                }

                SetStatus("Enabled: " + name);
            }
        }

        private void ButtonDisable_Click(object sender, EventArgs e)
        {
            string name = GridViewModsOffsets.GetRowCellValue(GridViewModsOffsets.FocusedRowHandle, GridViewModsOffsets.Columns[2]).ToString();
            List<Offset> offsets = ModsOffsets.GetOffsetsByModName(ConsoleType.ToString(), SelectedGameId, name, SelectedGameMode);

            if (offsets == null)
            {
                SetStatus("Can't find offsets.");
            }
            else
            {
                foreach (var offset in offsets)
                {
                    if (offset.Type.Equals("hex"))
                    {
                        WriteMemory(uint.Parse(offset.Address), offset.Disable.HexToBytes());
                        System.Threading.Thread.Sleep(100);
                    }
                    else
                    {
                        WriteMemory(uint.Parse(offset.Address), offset.Disable.ToBytes());
                        System.Threading.Thread.Sleep(100);
                    }
                }

                SetStatus("Disabled: " + name);
            }
        }

        private void WriteMemory(uint offset, byte[] bytes)
        {
            switch (ConsoleType)
            {
                case ConsoleTypePrefix.PS3:
                    PS3.SetMemory(offset, bytes);
                    break;
                case ConsoleTypePrefix.XBOX:
                    XBOX.WriteBytes(offset, bytes);
                    break;
            }
        }

        /// <summary>
        /// Enable/disable console controls.
        /// </summary>
        private void EnableConsoleActions()
        {
            ButtonSetValue.Enabled = IsConsoleConnected;
        }

        /// <summary>
        /// Set the connected console name in the status menu.
        /// </summary>
        /// <param name="consoleName"></param>
        private void SetStatusConsole(string consoleName)
        {
            LabelConsoleName.Caption = string.IsNullOrEmpty(consoleName) ? "Idle" : consoleName;
            Refresh();
        }

        /// <summary>
        /// Set the current status.
        /// </summary>
        /// <param name="text"> </param>
        private void SetStatus(string text, Exception ex = null)
        {
            LabelStatus.Caption = text;
            Refresh();

            if (ex != null)
            {
                Program.Log.Error(ex, text);
            }
        }
    }
}