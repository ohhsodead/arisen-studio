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
        public XMessageboxUI(string title = "", string body = "", ButtonOptions options = ButtonOptions.YesNo)
        {
            InitializeComponent();
            LabelTitle.Text = title;
            LabelBody.Text = body;
            TransparencyKey = Color.FromName("MenuBar");

            if (options == ButtonOptions.Ok)
            {
                ButtonExtra.Visible = false;
                ButtonYes.Visible = false;
                ButtonNo.Visible = true;
                ButtonNo.Text = "OK";

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

        public enum ButtonOptions
        {
            YesNo,
            YesNoCancel,
            Ok
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.B)
            {
                Close();
            }
            else if (keyData == Keys.Up)
            {
                if (FocusedButton == ButtonNo)
                {
                    FocusedButton = ButtonYes;
                    ButtonYes.Focus();
                }
                else if (FocusedButton == ButtonYes)
                {
                    FocusedButton = ButtonExtra;
                    ButtonExtra.Focus();
                }
                else if (FocusedButton == ButtonExtra)
                {
                    FocusedButton = ButtonExtra;
                    ButtonExtra.Focus();
                }
            }
            else if (keyData == Keys.Down)
            {
                //buttons1.NavigateButtonDown();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        SimpleButton FocusedButton;

        private void XMessageboxUI_Load(object sender, EventArgs e)
        {
            FocusedButton = ButtonNo;
            ButtonNo.Focus();
        }
    }
}