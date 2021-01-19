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

namespace ModioX
{
    public partial class Xbox_Virtual_Controler : DevExpress.XtraEditors.XtraForm
    {
        Xbox XboxConsole = MainWindow.XboxConsole;

        public Xbox_Virtual_Controler()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XboxConsole.XboxShortcut(XboxShortcuts.Guide_Button);
        }
    }
}