﻿using DevExpress.XtraEditors;
using ArisenStudio.Forms.Windows;
using System;
using System.Resources;
using System.Windows.Forms;

namespace ArisenStudio.Forms.Dialogs
{
    public partial class PackagesFaqDialog : XtraForm
    {
        public PackagesFaqDialog()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

        private void PackagesFaqDialog_Load(object sender, EventArgs e)
        {
            Text = Language.GetString("LABEL_PACKAGES") + " - FAQ";

            GroupActivateDemo.Text = string.Format(Language.GetString("HOW_TO_ACTIVATE_DEMO_QUESTION"));
            LabelActivateDemo.Text = string.Format(Language.GetString("HOW_TO_ACTIVATE_DEMO"));

            GroupActivateRAP.Text = string.Format(Language.GetString("HOW_TO_ACTIVATE_RAP_QUESTION"));
            LabelActivateRAP.Text = string.Format(Language.GetString("HOW_TO_ACTIVATE_RAP"));

            ButtonClose.Text = Language.GetString("LABEL_OK");

            _ = ButtonClose.Focus();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }
    }
}