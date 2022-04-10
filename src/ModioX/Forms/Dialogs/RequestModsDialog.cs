using DevExpress.XtraEditors;
using ModioX.Database;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using System;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace ModioX.Forms.Dialogs
{
    public partial class RequestModsDialog : XtraForm
    {
        public RequestModsDialog()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

        private void RequestModsDialog_Load(object sender, EventArgs e)
        {
            foreach (Category category in MainWindow.Database.CategoriesData.Categories.OrderBy(x => x.Title))
            {
                TextBoxGameCategory.Properties.Items.Add(category.Title);
            }

            ComboBoxConsole.SelectedIndex = 0;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            //System.Net.WebRequest request = System.Net.WebRequest.Create("https://api.github.com/repos/ohhsodead/ModioX/issues");
            //request.Method = "POST";
            //string postData = "{'title':'testing', 'body':'testing testing'}";
            //byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            //request.ContentLength = byteArray.Length;
            //System.IO.Stream dataStream = request.GetRequestStream();
            //dataStream.Write(byteArray, 0, byteArray.Length);
            //dataStream.Close();
            //System.Net.WebResponse response = request.GetResponse();
            //Console.WriteLine(response.Headers.Get("url"));

            //var createIssue = new NewIssue("this thing doesn't work");
            //var issue = await _issuesClient.Create("octokit", "octokit.net", createIssue);

            //return;

            if (TextBoxModName.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include the mod name.", Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TextBoxGameCategory.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include the game title or category.", Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TextBoxDescription.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include some description, such as useful details, what is it or how it works.", Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TextBoxSourceLinks.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include at least one link to the download link or source code.", Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            XtraMessageBox.Show(this,
                "Thanks for your request!\n\nA Google Forms page will now open with all the information pre-filled automatically. You can also upload a compressed archive containing the files. Click the 'Submit' button to send your request.",
                "Opening Request Form", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OpenGoogleFormsPreFill(TextBoxModName.Text, TextBoxDescription.Text, TextBoxGameCategory.Text, ComboBoxConsole.SelectedItem as string, TextBoxCreators.Text, TextBoxRegion.Text, TextBoxSourceLinks.Text);

            ForceRefresh();
        }

        private void OpenGoogleFormsPreFill(string name, string description, string category, string console, string creator, string region, string links)
        {
            string url = $"https://docs.google.com/forms/d/e/1FAIpQLScbeLBheZWjAp03d281pQHL2RvU93SLx2UXQZddx8i2nS2JmA/viewform?usp=pp_url" +
                $"&entry.1884265043={name}" +
                $"&entry.1389515172={description}" +
                $"&entry.841012679={category}" +
                $"&entry.188495311={console}" +
                $"&entry.491838807={creator}" +
                $"&entry.496892414={region}" +
                $"&entry.1503890983={links}";

            Process.Start(url);
        }
    }
}