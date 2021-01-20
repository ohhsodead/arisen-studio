using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModioX.Forms.Tools.XBOX_Tools
{
    public partial class GameLauncher : DevExpress.XtraEditors.XtraForm
    {
        public GameLauncher()
        {
            InitializeComponent();
        }

        private void GameLauncher_BackColorChanged(object sender, EventArgs e)
        {
            listView1.BackColor = BackColor;
            listView1.ForeColor = ForeColor;
        }
    }
}