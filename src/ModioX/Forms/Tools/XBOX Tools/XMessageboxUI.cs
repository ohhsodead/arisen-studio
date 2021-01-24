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
    public partial class XMessageboxUI : Form
    {
        public XMessageboxUI(string title = "", string body = "", ButtonOptions options = ButtonOptions.YesNo)
        {
            InitializeComponent();

            LabelTitle.Text = title;
            LabelBody.Text = body;

            if (options == ButtonOptions.Ok)
            {
                ButtonExtra.Visible = false;
                ButtonYes.Visible = false;
                ButtonNo.Visible = true;
                ButtonNo.Text = "OK";
                ButtonNo.DialogResult = DialogResult.OK;
            }
            else if (options == ButtonOptions.YesNo)
            {
                ButtonExtra.Visible = false;
                ButtonYes.Visible = true;
                ButtonNo.Visible = true;
            }
            else if (options == ButtonOptions.YesNoCancel)
            {
                ButtonExtra.Visible = true;
                ButtonYes.Visible = true;
                ButtonNo.Visible = true;
            }
        }

        Button FocusedButton = null;

        private void XMessageboxUI_Load(object sender, EventArgs e)
        {
            FocusedButton = ButtonNo;
            DoMouseHover(ButtonNo);
        }

        public enum ButtonOptions
        {
            YesNo,
            YesNoCancel,
            Ok
        }

        private void DoMouseHover(Button button)
        {
            ResetButtons();

            FocusedButton = button;

            button.BackColor = Color.FromArgb(108, 165, 14);//green
            button.ForeColor = Color.White;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            ResetButtons();

            var button = (Button)sender;

            button.BackColor = Color.FromArgb(108, 165, 14);//green
            button.ForeColor = Color.White;

            FocusedButton = button;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ResetButtons();

            var button = (Button)sender;

            if (FocusedButton != button)
            {
                button.BackColor = Color.FromArgb(212, 220, 220);//white
                button.ForeColor = Color.Black;
            }

            FocusedButton = null;
        }

        private void ResetButtons()
        {
            ButtonExtra.BackColor = Color.FromArgb(212, 220, 220);//white
            ButtonExtra.ForeColor = Color.Black;
            ButtonNo.BackColor = Color.FromArgb(212, 220, 220);//white
            ButtonNo.ForeColor = Color.Black;
            ButtonYes.BackColor = Color.FromArgb(212, 220, 220);//white
            ButtonYes.ForeColor = Color.Black;
        }

        private void Button_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private void Button_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.IsInputKey = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.B | keyData == Keys.Escape)
            {
                Close();
            }
            else if (keyData == Keys.A | keyData == Keys.Enter)
            {
                FocusedButton.PerformClick();
            }
            else if (keyData == Keys.Up)
            {
                if (FocusedButton == ButtonNo)
                {
                    DoMouseHover(ButtonYes);
                }
                else if (FocusedButton == ButtonYes)
                {
                    DoMouseHover(ButtonExtra);
                }
                else if (FocusedButton == ButtonExtra)
                {
                    DoMouseHover(ButtonExtra);
                }
            }
            else if (keyData == Keys.Down)
            {
                if (FocusedButton == ButtonExtra)
                {
                    DoMouseHover(ButtonYes);
                }
                else if (FocusedButton == ButtonYes)
                {
                    DoMouseHover(ButtonNo);
                }
                else if (FocusedButton == ButtonNo)
                {
                    DoMouseHover(ButtonNo);
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}