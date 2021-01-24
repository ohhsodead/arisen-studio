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
    public partial class CheatEngine : DevExpress.XtraEditors.XtraForm
    {
        public CheatEngine()
        {
            InitializeComponent();
        }

        private void CheatEngine_Load(object sender, EventArgs e)
        {
            // example of datatable (im going to add a function to create a datatable with the specified details (columns & rows)
            // so we dont need to create a new one like this everytime, because we're using datatable a lot - it make sense

            var ScannedAddresses = new DataTable();
            ScannedAddresses.Columns.Add("Address", typeof(string));
            ScannedAddresses.Columns.Add("Value", typeof(string));
            ScannedAddresses.Columns.Add("Previous", typeof(string));

            ScannedAddresses.Rows.Add("address", "value", "previous");

            GridControlScannedAddresses.DataSource = ScannedAddresses;

            var ModifiedValues = new DataTable();
            ModifiedValues.Columns.Add("Address", typeof(bool));
            ModifiedValues.Columns.Add("Value", typeof(string));
            ModifiedValues.Columns.Add("Previous", typeof(string));
            ModifiedValues.Columns.Add("Previous", typeof(string));
            ModifiedValues.Columns.Add("Previous", typeof(string));

            ModifiedValues.Rows.Add("address", "value", "previous");

            GridControlModifyValues.DataSource = ModifiedValues;
        }
    }
}