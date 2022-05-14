using DevExpress.XtraEditors;
using Modio.Extensions;
using Modio.Forms.Windows;
using System;
using XDevkit;

namespace Modio.Forms.Tools.XBOX
{
    public partial class GameLauncher : XtraForm
    {
        public GameLauncher()
        {
            InitializeComponent();
        }

        public static IXboxConsole XboxConsole { get; } = MainWindow.XboxConsole;

        private void GameLauncher_Load(object sender, EventArgs e)
        {
            LabelNoGames.Visible = MainWindow.Settings.GameFilesXBOX.Count <= 0;

            UpdateStatus("Fetching games list...");

            foreach (ListItem game in MainWindow.Settings.GameFilesXBOX)
            {
                ListBoxGames.Items.Add(game.Name);
            }

            UpdateStatus("Successfully fetched your games.");
        }

        private void ListBoxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonLaunchGame.Enabled = ListBoxGames.SelectedIndex != -1;
        }

        private void ButtonLaunchGame_Click(object sender, EventArgs e)
        {
            UpdateStatus("Launching game...");

            ListItem gameItem = MainWindow.Settings.GameFilesXBOX[ListBoxGames.SelectedIndex];
            XboxConsole.LaunchXEX(gameItem.Value, gameItem.Value);

            UpdateStatus("Successfully launched game.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        /// <param name="ex"></param>
        public void UpdateStatus(string status, Exception ex = null)
        {
            LabelStatus.Caption = status;

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