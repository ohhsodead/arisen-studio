using ModioX.Forms.Windows;
using System;
using XDevkit;

namespace ModioX.Forms.Tools.XBOX_Tools
{
    public partial class GameLauncher : DevExpress.XtraEditors.XtraForm
    {
        public static Xbox XboxConsole { get; } = MainWindow.XboxConsole;

        public GameLauncher()
        {
            InitializeComponent();
        }

        private void GameLauncher_Load(object sender, EventArgs e)
        {

        }

        private void ButtonFetchGames_Click(object sender, EventArgs e)
        {
            ListBoxGames.Items.Clear();

            //foreach (IXboxFile file in XboxConsole.File.DirectoryFiles(TextBoxGamesPath.Text.ToUpper()))
            //{
            //    if (file.IsDirectory)
            //    {
            //        ListBoxGames.Items.Add(file.Name.Replace(TextBoxGamesPath.Text.ToUpper(), string.Empty));
            //    }
            //}
        }
    }
}