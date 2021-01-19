using DevExpress.XtraEditors;
using ModioX.Forms.Tools.XBOX_Tools;
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
    public partial class XMessageButtons : UserControl, IMessageFilter
    {
        public Options options { get; set; } = Options.YesNo;

        public XMessageButtons()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);

            UpdateButtons();
        }

        private void UpdateButtons()
        {
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

        public bool PreFilterMessage(ref Message m)
        {
            if (!IsDisposed && ClientRectangle.Contains(PointToClient(MousePosition)))
            {
                BackColor = Color.FromArgb(108, 165, 14);
            }
            else
            {
                BackColor = Color.FromArgb(218, 225, 227);
            }
            return false;
        }

        public void NavigateButtonUp()
        {
            if (SelectedPanel == ButtonExtra)
            {
                // do nothing as this is the top button
            }
            else if (SelectedPanel == ButtonYes)
            {
                if (ButtonExtra.Visible)
                {
                    SelectedPanel = ButtonExtra;
                }
            }
            else if (SelectedPanel == ButtonNo)
            {
                SelectedPanel = ButtonYes;
            }

            RefreshButtons();
        }

        public void NavigateButtonDown()
        {
            if (SelectedPanel == ButtonExtra)
            {
                SelectedPanel = ButtonYes;
            }
            else if (SelectedPanel == ButtonYes)
            {
                SelectedPanel = ButtonNo;
            }
            else if (SelectedPanel == ButtonNo)
            {
                // do nothing as this is the bottom button
            }

            RefreshButtons();
        }

        private void RefreshButtons()
        {
            ButtonExtra.BackColor = Color.FromArgb(212, 220, 220);
            ButtonText1.ForeColor = Color.Black;
            ButtonYes.BackColor = Color.FromArgb(212, 220, 220);
            ButtonText2.ForeColor = Color.Black;
            ButtonNo.BackColor = Color.FromArgb(212, 220, 220);
            ButtonText3.ForeColor = Color.Black;

            foreach (var ctrl in Controls)
            {
                if (SelectedPanel == ctrl)
                {
                    ButtonHover(SelectedPanel);
                }
            }

            Refresh();
        }

        public Panel SelectedPanel;
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

                RefreshButtons();

                /*
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
                */
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

                RefreshButtons();
            }
            catch
            {
                
            }
        }

        private void ButtonHover(Panel panel)
        {
            SelectedPanel = panel;

            panel.BackColor = Color.FromArgb(108, 165, 14);

            foreach (var ctrl in panel.Controls)
            {
                ((LabelControl)ctrl).ForeColor = Color.Transparent;
            }
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

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            XMessageboxUI parent = Parent as XMessageboxUI;
            parent.DialogResult = DialogResult.Yes;
            parent.ButtonNo.PerformClick();

            //ButtonHolderYes.PerformClick();
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            //if (ButtonText3.Text == "Ok")
            //{
            //    ButtonHolderOK.PerformClick();
            //}
            //else
            //{
            //    ButtonHolderNo.PerformClick();
            //}
        }

        private void ButtonExtra_Click(object sender, EventArgs e)
        {
            //ButtonHolderCancel.PerformClick();
        }

        private void XMessageButtons_Load(object sender, EventArgs e)
        {

        }
    }
}
