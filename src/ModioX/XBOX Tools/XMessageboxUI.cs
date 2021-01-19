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
    public partial class XMessageboxUI : DevExpress.XtraEditors.XtraForm
    {
        public XMessageboxUI(string title = "", string body = "", Buttons buttons = Buttons.YesNo)
        {
            InitializeComponent();
            LabelTitle.Text = title;
            LabelBody.Text = body;
            this.TransparencyKey = Color.FromName("MenuBar");

        }

        Panel SelectedPanel;

        public enum Buttons
        {
            YesNo,
            YesNoCancel,
            Ok
        }

        private void Button_MouseHover(object sender, EventArgs e)//bug when hover
        {
            var panel = (Panel)sender;
            SelectedPanel = panel;

            panel.BackColor = Color.FromArgb(108, 165, 14); // lolz

            if (SelectedPanel != panel)
            {
                panel.BackColor = Color.FromArgb(218, 225, 227);

                foreach (var ctrl in panel.Controls)
                {
                    ((LabelControl)ctrl).ForeColor = Color.Black;
                }
            }
            else
            {
                foreach (var ctrl in panel.Controls)
                {
                    ((LabelControl)ctrl).ForeColor = Color.Transparent;
                }
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            var panel = (Panel)sender;
            SelectedPanel = panel;

            if (SelectedPanel != panel)
            {
                panel.BackColor = Color.FromArgb(218, 225, 227);

                foreach (var ctrl in panel.Controls)
                {
                    ((LabelControl)ctrl).ForeColor = Color.Black;
                }
            }
            else
            {
                foreach (var ctrl in panel.Controls)
                {
                    ((LabelControl)ctrl).ForeColor = Color.Transparent;
                }
            }
        }

        private void ButtonHover(Panel panel)
        {
            panel.BackColor = Color.FromArgb(108, 165, 14);

            foreach (var ctrl in panel.Controls)
            {
                ((LabelControl)ctrl).ForeColor = Color.Transparent;
            }
        }

        //private void ButtonLeave(Panel panel)
        //{
        //    panel.BackColor = Color.FromArgb(218, 225, 225); // lolz //218, 225, 225

        //    foreach (var ctrl in panel.Controls)
        //    {
        //        ((LabelControl)ctrl).ForeColor = Color.Black;
        //    }
        //}


 
    }
}