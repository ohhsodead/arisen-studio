using System;
using DevExpress.XtraEditors;
using ModioX.Forms.Windows;
using XDevkit;

namespace ModioX.Forms.Tools.XBOX_Tools
{
    public partial class GameLauncher : XtraForm
    {
        public static IXboxConsole XboxConsole { get; } = MainWindow.XboxConsole;

        public GameLauncher()
        {
            InitializeComponent();
        }

        private void GameLauncher_Load(object sender, EventArgs e)
        {
        }

        private void ButtonFetchGames_Click(object sender, EventArgs e)
        {
        }
    }
}