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
            //if only 1 button it will be set the color as you have selected by default ... sorry, i mean have the buttons text as they would be buttontext1/2/3
            // noo, like the actual buttons text e.g. YES, NO, OK, CANCEL or what? for now yes/no
            
            if (buttons == Buttons.YesNo)//panels and text must visible = false etc
            {
                ButtonExtra.Visible = false;
                ButtonYes.Visible = true;
                ButtonNo.Visible = true;
                ButtonText3.Text = "No";
                SelectedPanel = ButtonNo;
                ButtonHover(ButtonNo);
            }
            else if (buttons == Buttons.YesNoCancel)//by default if 3 buttons bottom one is green
            {
                ButtonExtra.Visible = true;
                ButtonYes.Visible = true;
                ButtonNo.Visible = true;
                ButtonText3.Text = "No";
                SelectedPanel = ButtonNo;
                ButtonHover(ButtonNo);
            }
            else if (buttons == Buttons.Ok)
            {
                ButtonExtra.Visible = false;
                ButtonYes.Visible = false;
                ButtonNo.Visible = true;
                ButtonText3.Text = "Ok";
                SelectedPanel = ButtonNo;
                ButtonHover(ButtonNo);
            }
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
                panel.BackColor = Color.FromArgb(218, 225, 225);

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
                panel.BackColor = Color.FromArgb(218, 225, 225);

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

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            XtraMessageBox.Show("Width: " + Width + " Height: " + Height);
            Close();
        }

 
    }
}