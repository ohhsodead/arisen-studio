using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ModioX.Database;
using ModioX.Extensions;
using ModioX.Models.Database;
using ModioX.Models.Resources;
using PS3Lib;
using XDevkit;

namespace ModioX.Forms.Windows
{
    public partial class OffsetsPokerWindow : XtraForm
    {
        public OffsetsPokerWindow()
        {
            InitializeComponent();
        }

        private CategoriesData Categories { get; } = MainWindow.Database.CategoriesData;

        private OffsetsData ModsOffsets { get; } = MainWindow.Database.ModsOffsets;

        private ConsoleProfile ConsoleProfile { get; set; } = MainWindow.ConsoleProfile;

        private PS3API PS3 { get; set; } = new(SelectAPI.PS3Manager);

        private IXboxConsole XBOX { get; set; }

        private bool IsConsoleConnected { get; set; }

        private PlatformPrefix ConsoleType { get; set; } = MainWindow.PlatformType;

        private string SelectedGameId { get; set; } = "";

        private string SelectedGameMode { get; set; } = "";

        private string SelectedCategory { get; set; } = "";

        private void OffsetsPokerWindow_Load(object sender, EventArgs e)
        {

        }

        private void TimerWait_Tick(object sender, EventArgs e)
        {
            ComboBoxGameTitles.Properties.Items.Clear();
            ComboBoxCategory.Properties.Items.Clear();
            ComboBoxCategory.Properties.Items.Add("ALL");

            foreach (Category category in Categories.GetCategoriesByType(CategoryType.Game))
            {
                List<ModsOffsets> mods = ModsOffsets.GetModsByConsoleTypeAndGameId(ConsoleType.ToString(), category.Id);

                switch (mods.Count)
                {
                    case > 0:
                        ComboBoxGameTitles.Properties.Items.Add(category.Title);
                        break;
                }

                foreach (ModsOffsets mod in mods)
                {
                    foreach (Memory offset in mod.Memory)
                    {
                        if (offset.Category.ContainsIgnoreCase(SelectedCategory) &&
                            !ComboBoxCategory.Properties.Items.Contains(offset.Category))
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
                if (PS3.ConnectTarget(ConsoleProfile.Address))
                {
                    if (PS3.AttachProcess())
                    {
                        IsConsoleConnected = true;

                        SetStatusConsole(true);
                        ConsoleType = PlatformPrefix.PS3;
                        EnableConsoleActions();

                        MenuItemConnectToPS3.Visibility = BarItemVisibility.Never;
                        MenuItemDisconnectPS3.Visibility = BarItemVisibility.Always;

                        MenuItemConnectToXBOX.Enabled = false;

                        XtraMessageBox.Show(this, "Connected and attached to console.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                SetStatusConsole(false);
                EnableConsoleActions();

                MenuItemConnectToPS3.Visibility = BarItemVisibility.Always;
                MenuItemDisconnectPS3.Visibility = BarItemVisibility.Never;

                MenuItemConnectToXBOX.Enabled = true;

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
        /// </summary>
        private void ConnectToXBOX()
        {
            try
            {
                XBOX = MainWindow.XboxConsole;
                IsConsoleConnected = true;

                SetStatusConsole(true);
                ConsoleType = PlatformPrefix.XBOX;
                EnableConsoleActions();

                MenuItemConnectToXBOX.Visibility = BarItemVisibility.Never;
                MenuItemDisconnectXBOX.Visibility = BarItemVisibility.Always;

                MenuItemConnectToPS3.Enabled = false;

                XtraMessageBox.Show(this, "Connected and attached to console.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, "Unable to connect to console.\n\nError Message:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// </summary>
        private void DisconnectFromXBOX()
        {
            try
            {
                PS3.DisconnectTarget();

                IsConsoleConnected = false;

                SetStatusConsole(false);
                EnableConsoleActions();

                MenuItemConnectToXBOX.Visibility = BarItemVisibility.Always;
                MenuItemDisconnectXBOX.Visibility = BarItemVisibility.Never;

                MenuItemConnectToPS3.Enabled = true;

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
                switch (ComboBoxGameMode.SelectedIndex)
                {
                    case 0:
                        SelectedGameMode = string.Empty;
                        LoadGameMods();
                        return;
                    default:
                        SelectedGameMode = ComboBoxGameMode.SelectedItem.ToString();
                        LoadGameMods();
                        break;
                }
            }
        }

        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxCategory.SelectedIndex != -1)
            {
                switch (ComboBoxCategory.SelectedIndex)
                {
                    case 0:
                        SelectedCategory = string.Empty;
                        LoadGameMods();
                        return;
                    default:
                        SelectedCategory = ComboBoxCategory.SelectedItem.ToString();
                        LoadGameMods();
                        break;
                }
            }
        }

        private DataTable DataTableMods = DataExtensions.CreateDataTable(new List<DataColumn>
            {
                new("Console Type"),
                new("Toggleable"),
                new("Name"),
                new("Game Mode"),
                new("Category")
            });

        private void LoadGameMods()
        {
            GridModsOffsets.DataSource = null;

            foreach (ModsOffsets modsOffsets in ModsOffsets.GetMods(ConsoleType.ToString(), SelectedGameId, SelectedGameMode, SelectedCategory))
            {
                foreach (Memory memory in modsOffsets.Memory)
                {
                    DataTableMods.Rows.Add(modsOffsets.ConsoleType,
                                       memory.Toggleable.ToString(),
                                       memory.Name,
                                       memory.GameMode,
                                       memory.Category);
                }
            }

            GridModsOffsets.DataSource = DataTableMods;

            GridViewModsOffsets.Columns[0].Visible = false;
            GridViewModsOffsets.Columns[1].Visible = false;
            GridViewModsOffsets.Columns[2].Width = 250;
            GridViewModsOffsets.Columns[3].Width = 75;

            switch (DataTableMods.Rows.Count)
            {
                case < 1:
                    MessageBox.Show("Game Id: " + SelectedGameId + "\nGame Mode: " + SelectedGameMode + "\nCategory: " + SelectedCategory);
                    ButtonSetValue.Visible = false;
                    ButtonEnable.Visible = false;
                    ButtonDisable.Visible = false;
                    break;
            }
        }

        private void GridViewPackageFiles_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            //ButtonDeletePackageFile.Enabled = GridViewModsOffsets.SelectedRowsCount > 0;
            //ButtonDownloadPackageFile.Enabled = GridViewModsOffsets.SelectedRowsCount > 0;

            switch (GridViewModsOffsets.SelectedRowsCount)
            {
                case > 0:
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

                        break;
                    }
                default:
                    ButtonSetValue.Enabled = false;
                    ButtonEnable.Enabled = false;
                    ButtonDisable.Enabled = false;
                    break;
            }
        }

        private void GridViewPackageFiles_RowClick(object sender, RowClickEventArgs e)
        {
            //ButtonSetValue.Enabled = GridViewModsOffsets.SelectedRowsCount > 0;
            //ButtonDownloadPackageFile.Enabled = GridViewModsOffsets.SelectedRowsCount > 0;
            //XBOX.WriteBytes(123, Encoding.ASCII.GetBytes(""));
            //PS3.SetMemory(123, new byte[1]);
        }

        private void ButtonSetValue_Click(object sender, EventArgs e)
        {
            string name = GridViewModsOffsets.GetRowCellValue(GridViewModsOffsets.FocusedRowHandle, GridViewModsOffsets.Columns[2]).ToString();
            List<Offset> offsets = ModsOffsets.GetOffsetsByModName(ConsoleType.ToString(), SelectedGameId, name, SelectedGameMode);

            switch (offsets)
            {
                case null:
                    MessageBox.Show("Can't find offsets.");
                    SetStatus("Can't find offsets.");
                    break;
                default:
                    {
                        foreach (Offset offset in offsets)
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
                                switch (offset.Type)
                                {
                                    case "string":
                                        {
                                            string text = DialogExtensions.ShowTextInputDialog(this, "Set Value", name);

                                            if (text.IsNullOrWhiteSpace())
                                            {
                                                XtraMessageBox.Show("You must enter a value.", "Empty Value", MessageBoxButtons.OK,
                                                    MessageBoxIcon.Exclamation);
                                                return;
                                            }

                                            if (name.EqualsIgnoreCase("name"))
                                            {
                                                WriteMemory(uint.Parse(offset.Address), Encoding.ASCII.GetBytes(text + '\0'));
                                            }
                                            else
                                            {
                                                WriteMemory(uint.Parse(offset.Address), Encoding.ASCII.GetBytes(text));
                                            }

                                            SetStatus("New Value Set: " + name + " to: " + text);
                                            break;
                                        }
                                    case "int":
                                        {
                                            int? number = DialogExtensions.ShowNumberInputDialog(this, "Set Value", name);

                                            switch (number)
                                            {
                                                case null:
                                                    XtraMessageBox.Show("You must enter a value.", "Empty Value", MessageBoxButtons.OK,
                                                        MessageBoxIcon.Exclamation);
                                                    return;
                                            }

                                            WriteMemory(uint.Parse(offset.Address), BitConverter.GetBytes(Convert.ToInt32(number)));
                                            SetStatus("New Value Set: " + name + " to: " + number);
                                            break;
                                        }
                                    case "hex":
                                        WriteMemory(uint.Parse(offset.Address), offset.Value.HexToBytes());
                                        SetStatus("New Value Set.");
                                        break;
                                }
                            }
                            else
                            {
                                //WriteMemory(uint.Parse(offset.Address), Encoding.ASCII.GetBytes(offset.Value));
                                WriteMemory(uint.Parse(offset.Address), offset.Value.ToBytes());
                                SetStatus("New Value Set.");
                                Thread.Sleep(100);
                            }
                        }

                        //string source = "0x20, 0x64, 0x26, 0x00";

                        //var result = source.GetBytes();

                        //string test = string.Join(", ", result.Select(item => "0x" + item.ToString("x2")));

                        //MessageBox.Show(test);

                        //MessageBox.Show(BitConverter.ToString(result));
                        break;
                    }
            }
        }

        private void ButtonEnable_Click(object sender, EventArgs e)
        {
            string name = GridViewModsOffsets.GetRowCellValue(GridViewModsOffsets.FocusedRowHandle, GridViewModsOffsets.Columns[2]).ToString();
            List<Offset> offsets = ModsOffsets.GetOffsetsByModName(ConsoleType.ToString(), SelectedGameId, name, SelectedGameMode);

            switch (offsets)
            {
                case null:
                    SetStatus("Can't find offsets.");
                    break;
                default:
                    {
                        foreach (Offset offset in offsets)
                        {
                            switch (offset.Type)
                            {
                                case "hex":
                                    WriteMemory(uint.Parse(offset.Address), offset.Enable.HexToBytes());
                                    Thread.Sleep(100);
                                    break;
                                default:
                                    WriteMemory(uint.Parse(offset.Address), offset.Enable.ToBytes());
                                    Thread.Sleep(100);
                                    break;
                            }
                        }

                        SetStatus("Enabled: " + name);
                        break;
                    }
            }
        }

        private void ButtonDisable_Click(object sender, EventArgs e)
        {
            string name = GridViewModsOffsets.GetRowCellValue(GridViewModsOffsets.FocusedRowHandle, GridViewModsOffsets.Columns[2]).ToString();
            List<Offset> offsets = ModsOffsets.GetOffsetsByModName(ConsoleType.ToString(), SelectedGameId, name, SelectedGameMode);

            switch (offsets)
            {
                case null:
                    SetStatus("Can't find offsets.");
                    break;
                default:
                    {
                        foreach (Offset offset in offsets)
                        {
                            switch (offset.Type)
                            {
                                case "hex":
                                    WriteMemory(uint.Parse(offset.Address), offset.Disable.HexToBytes());
                                    Thread.Sleep(100);
                                    break;
                                default:
                                    WriteMemory(uint.Parse(offset.Address), offset.Disable.ToBytes());
                                    Thread.Sleep(100);
                                    break;
                            }
                        }

                        SetStatus("Disabled: " + name);
                        break;
                    }
            }
        }

        private void WriteMemory(uint offset, byte[] bytes)
        {
            switch (ConsoleType)
            {
                case PlatformPrefix.PS3:
                    PS3.Extension.WriteBytes(offset, bytes);
                    break;
                case PlatformPrefix.XBOX:
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
        /// <param name="connected"></param>
        private void SetStatusConsole(bool connected)
        {
            LabelConsoleName.Caption = connected ? ConsoleType.ToString() : "Idle";
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