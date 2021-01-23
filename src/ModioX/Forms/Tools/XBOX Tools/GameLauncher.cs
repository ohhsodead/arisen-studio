using DevExpress.XtraEditors;
using ModioX.Forms.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void GameLauncher_BackColorChanged(object sender, EventArgs e)
        {
            listView1.BackColor = BackColor;
            listView1.ForeColor = ForeColor;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = textBox1.Text;
            //listView1.Clear();
            //ColumnHeader header = new ColumnHeader
            //{
            //    Width = 330,
            //    Text = "Games",
            //    Name = "col1"
            //};
            //listView1.Columns.Add(header);
            //foreach (IXboxFile file in XboxConsole.File.DirectoryFiles(textBox1.Text.ToUpper()))
            //{
            //    if (file.IsDirectory)
            //    {
            //        listView1.Items.Add(file.Name.Replace(textBox1.Text.ToUpper(), string.Empty));
            //    }
            //}
            //listView1.Focus();
        }
    }
}