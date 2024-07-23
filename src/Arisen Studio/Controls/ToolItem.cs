using DevExpress.XtraEditors;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArisenStudio.Controls
{
    public partial class ToolItem : XtraUserControl, IMessageFilter
    {
        public ToolItem()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
        }

        public string ToolName { get; set; } = "Tool Name";

        public string Description { get; set; } = "Description";

        public XtraForm ToolForm { get; set; }

        public void ReloadControls()
        {
            LabelName.Text = Name;
            LabelDescription.Text = Description;
        }

        public bool IsSelected { get; set; }

        public bool ShouldHover { get; set; } = true;

        public bool PreFilterMessage(ref Message m)
        {
            if (ShouldHover)
            {
                switch (IsDisposed)
                {
                    case false when ClientRectangle.Contains(PointToClient(MousePosition)):
                        BackColor = MainWindow.SkinColors.GetColor("Highlight");
                        break;
                    default:
                        {
                            BackColor = IsSelected switch
                            {
                                false => Color.Transparent,
                                _ => BackColor
                            };

                            break;
                        }
                }
            }

            return false;
        }

        public new event EventHandler OnClick
        {
            add
            {
                Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += value;
                }
            }
            remove
            {
                Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= value;
                }
            }
        }

        public new event EventHandler OnDoubleClick
        {
            add
            {
                DoubleClick += value;
                foreach (Control control in Controls)
                {
                    control.DoubleClick += value;
                }
            }
            remove
            {
                DoubleClick -= value;
                foreach (Control control in Controls)
                {
                    control.DoubleClick -= value;
                }
            }
        }

        private void ButtonLaunch_Click(object sender, EventArgs e)
        {
            ToolForm.ShowDialog(this);
        }

        private void PanelControls_EnabledChanged(object sender, EventArgs e)
        {
            LabelName.Enabled = Enabled;
            LabelDescription.Enabled = Enabled;
            ButtonLaunch.Enabled = Enabled;
        }

        private void ToolItem_EnabledChanged(object sender, EventArgs e)
        {
            LabelName.Enabled = Enabled;
            LabelDescription.Enabled = Enabled;
            ButtonLaunch.Enabled = Enabled;
        }
    }
}