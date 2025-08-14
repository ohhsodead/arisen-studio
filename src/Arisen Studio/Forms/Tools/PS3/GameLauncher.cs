using DevExpress.XtraEditors;
using ArisenStudio.Forms.Windows;
using System;
using System.Resources;
using System.Windows.Forms;
using ArisenStudio.Models.Resources;

namespace ArisenStudio.Forms.Tools.PS3
{
    public partial class GameLauncher : XtraForm
    {
        public GameLauncher()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

        public ConsoleProfile Profile = MainWindow.ConsoleProfile;

        private void GameLauncher_Load(object sender, EventArgs e)
        {
            try
            {
                SetStatus("Loading games...");

                WebViewGames.Source = new Uri("http://" + MainWindow.ConsoleProfile.Address + "/games.ps3?");

                SetStatus("Successfully loaded games.");
            }
            catch (Exception ex)
            {
                SetStatus("Game Launcher (PS3): " + "Unable to load games", ex);
                _ = XtraMessageBox.Show(this, "Unable to load games", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private async void WebViewGames_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                WebViewGames.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
                WebViewGames.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;

                try
                {
                    _ = await WebViewGames.ExecuteScriptAsync("document.getElementById('iwrap').style.display = 'none';");
                    _ = await WebViewGames.ExecuteScriptAsync("document.getElementById('search').style.display = 'none';");
                    _ = await WebViewGames.ExecuteScriptAsync("document.getElementById('menu-icon').style.display = 'none';");
                }
                catch { }

                if (WebViewGames.Source.ToString().Contains("mount.ps3"))
                {
                    WebViewGames.Source = new Uri("http://" + MainWindow.ConsoleProfile.Address + "/play.ps3?");
                }

                if (WebViewGames.Source.ToString().Contains("play.ps3"))
                {
                    Close();
                }

                //WebViewGames.Source = new Uri("http://" + MainWindow.ConsoleProfile.Address + "/xmb.ps3$exit");
            }
        }

        private void WebViewGames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {

            }
            else
            {
                if (Convert.ToBoolean(e.Modifiers))
                {

                }
                else if (e.KeyCode == Keys.Delete)
                {
                    e.Handled = true;
                }
                else
                {

                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        /// <param name="ex"></param>
        public void SetStatus(string status, Exception ex = null)
        {
            if (InvokeRequired)
            {
                _ = BeginInvoke((MethodInvoker)delegate
                {
                    LabelStatus.Caption = status;
                });
            }
            else
            {
                LabelStatus.Caption = status;
            }

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