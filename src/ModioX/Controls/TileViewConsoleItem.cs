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

namespace ModioX.Controls
{
    public partial class TileViewConsoleItem : XtraUserControl, IMessageFilter
    {
        public TileViewConsoleItem(string consoleName, Image image)
        {
            InitializeComponent();
            ImageConsole.Image = image;
            LabelConsoleName.Text = consoleName;
            Application.AddMessageFilter(this);
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (!IsDisposed && ClientRectangle.Contains(PointToClient(MousePosition)))
            {
                BackColor = Color.DimGray;
            }
            else
            {
                BackColor = Color.Transparent;
            }
            return false;
        }

        public new event EventHandler OnClick
        {
            add
            {
                base.Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += value;
                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= value;
                }
            }
        }
    }
}