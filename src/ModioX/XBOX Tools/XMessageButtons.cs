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

namespace ModioX
{
    public partial class Buttons : UserControl
    {
        public Options options { get; set; } = Options.YesNoCancel;
        public Buttons()
        {
            InitializeComponent();

            if (options == Options.YesNo)//panels and text must visible = false etc
            {
                ButtonExtra.Visible = false;
                ButtonYes.Visible = true;
                ButtonNo.Visible = true;
                ButtonText3.Text = "No";
                SelectedPanel = ButtonNo;
                ButtonHover(ButtonNo);
            }
            else if (options == Options.YesNoCancel)//by default if 3 buttons bottom one is green
            {
                ButtonExtra.Visible = true;
                ButtonYes.Visible = true;
                ButtonNo.Visible = true;
                ButtonText3.Text = "No";
                SelectedPanel = ButtonNo;
                ButtonHover(ButtonNo);
            }
            else if (options == Options.Ok)
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
        Label SelectedLabel;
        public enum Options
        {
            YesNo,
            YesNoCancel,
            Ok
        }

        private new Color BackColor { get; set; } = Color.Transparent;

        private void Button_MouseHover(object sender, EventArgs e)//bug when hover
        {//212, 220, 220
            try
            {
                var panel = (Panel)sender;
                SelectedPanel = panel;

                panel.BackColor = Color.FromArgb(108, 165, 14); // green

                if (SelectedPanel != panel)
                {
                    panel.BackColor = Color.FromArgb(212, 220, 220);//white

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
            catch
            {
                
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                var panel = (Panel)sender;
                SelectedPanel = panel;

                if (SelectedPanel != panel)
                {

                    panel.BackColor = Color.FromArgb(108, 165, 14);//green

                    foreach (var ctrl in panel.Controls)
                    {
                        ((LabelControl)ctrl).ForeColor = Color.Transparent;
                    }
                }
                else
                {
                    foreach (var ctrl in panel.Controls)
                    {
                        panel.BackColor = Color.FromArgb(212, 220, 220);//white
                        ((LabelControl)ctrl).ForeColor = Color.Black;
                    }
                }
            }
            catch
            {
                
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

        private void ButtonExtra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonNo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonYes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonText_MouseHover(object sender, EventArgs e)
        {
            try
            {
                var Label = (Label)sender;
                SelectedLabel = Label;

                Label.BackColor = Color.FromArgb(108, 165, 14); // green

                if (SelectedLabel != Label)
                {
                    Label.BackColor = Color.FromArgb(212, 220, 220);//white

                    foreach (var ctrl in Label.Controls)
                    {
                        ((LabelControl)ctrl).ForeColor = Color.Black;

                    }
                }
                else
                {

                    foreach (var ctrl in Label.Controls)
                    {
                        ((LabelControl)ctrl).ForeColor = Color.Transparent;
                    }
                }
            }
            catch
            {

            }
        }

        private void ButtonText_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                var Label = (Label)sender;
                SelectedLabel = Label;

                if (SelectedLabel != Label)
                {

                    Label.BackColor = Color.FromArgb(108, 165, 14);//green

                    foreach (var ctrl in Label.Controls)
                    {
                        ((LabelControl)ctrl).ForeColor = Color.Transparent;
                    }
                }
                else
                {
                    foreach (var ctrl in Label.Controls)
                    {
                        Label.BackColor = Color.FromArgb(212, 220, 220);//white
                        ((LabelControl)ctrl).ForeColor = Color.Black;
                    }
                }
            }
            catch
            {

            }
        }
    }
}
