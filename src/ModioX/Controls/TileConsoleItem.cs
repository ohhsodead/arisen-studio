using DevExpress.XtraEditors;
using ModioX.Forms.Windows;
using ModioX.Models.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ModioX.Controls
{
    public partial class TileConsoleItem : XtraUserControl, IMessageFilter
    {
        public TileConsoleItem(string consoleName, Image image)
        {
            InitializeComponent();
            ImageConsole.Image = image;
            LabelConsoleName.Text = consoleName;
            Application.AddMessageFilter(this);
        }

        public ConsoleProfile ConsoleProfile { get; set; }

        public bool IsSelected { get; set; }

        public bool PreFilterMessage(ref Message m)
        {
            if (!IsDisposed && ClientRectangle.Contains(PointToClient(MousePosition)))
            {
                BackColor = MainWindow.SkinColors.GetColor("Highlight");
            }
            else
            {
                if (!IsSelected)
                {
                    BackColor = Color.Transparent;
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
    }
}