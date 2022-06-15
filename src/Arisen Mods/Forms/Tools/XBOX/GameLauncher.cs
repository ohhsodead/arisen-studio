using DevExpress.XtraEditors;
using ArisenMods.Extensions;
using ArisenMods.Forms.Windows;
using System;
using System.Resources;
using System.Windows.Forms;
using XDevkit;

namespace ArisenMods.Forms.Tools.XBOX
{
    public partial class GameLauncher : XtraForm
    {
        public GameLauncher()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

        public static IXboxConsole XboxConsole { get; } = MainWindow.XboxConsole;

        private void GameLauncher_Load(object sender, EventArgs e)
        {
            Text = Language.GetString("GAMES_LAUNCHER");
            GroupGames.Text = Language.GetString("LABEL_GAMES");
            LabelNoGames.Text = Language.GetString("LABEL_NO_GAMES");
            ButtonEditName.Text = Language.GetString("LABEL_EDIT_NAME");
            ButtonLaunchGame.Text = Language.GetString("LABEL_LAUNCH_GAME");
            LoadGames();
        }

        private void LoadGames()
        {
            LabelNoGames.Visible = MainWindow.Settings.GameFilesXBOX.Count <= 0;

            UpdateStatus("Fetching games list...");

            foreach (ListItem game in MainWindow.Settings.GameFilesXBOX)
            {
                ListBoxGames.Items.Add(game.Name);
            }

            UpdateStatus("Successfully fetched games.");
        }

        private void ListBoxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonEditName.Enabled = ListBoxGames.SelectedIndex != -1;
            ButtonLaunchGame.Enabled = ListBoxGames.SelectedIndex != -1;
        }

        private void ButtonEditName_Click(object sender, EventArgs e)
        {
            string oldName = MainWindow.Settings.GameFilesXBOX[ListBoxGames.SelectedIndex].Name;
            string newName = DialogExtensions.ShowTextInputDialog(this, Language.GetString("GAME_FILE"), Language.GetString("LABEL_NAME") + ":", oldName);

            if (!newName.IsNullOrWhiteSpace())
            {
                MainWindow.Settings.GameFilesXBOX[ListBoxGames.SelectedIndex].Name = newName;
                XtraMessageBox.Show(this, Language.GetString("FILE_RENAMED_SUCCESS"), Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGames();
            }
        }

        private void ButtonLaunchGame_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateStatus("Launching game...");

                ListItem gameItem = MainWindow.Settings.GameFilesXBOX[ListBoxGames.SelectedIndex];
                XboxConsole.LaunchXEX(gameItem.Value, gameItem.Value);

                UpdateStatus("Successfully launched game.");
                XtraMessageBox.Show(this, Language.GetString("SUCCESS_LAUNCHED_GAME"), Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                UpdateStatus("Unable to launch game file. Error: " + ex.Message, ex);
                XtraMessageBox.Show(this, string.Format(Language.GetString("ERROR_LAUNCHING_GAME"), ex.Message), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        /// <param name="ex"></param>
        public void UpdateStatus(string status, Exception ex = null)
        {
            if (ex == null)
            {
                Program.Log.Info(status);
            }
            else
            {
                Program.Log.Error(ex, status);
            }
        }
    }
}