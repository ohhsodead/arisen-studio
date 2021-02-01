using DevExpress.XtraEditors;
using System;
using System.Data;

namespace ModioX.Forms.Tools.XBOX_Tools
{
    public partial class CheatEngine : XtraForm
    {
        public CheatEngine()
        {
            InitializeComponent();
        }

        private void CheatEngine_Load(object sender, EventArgs e)
        {
            // example of datatable (im going to add a function to create a datatable with the
            // specified details (columns & rows) so we dont need to create a new one like this
            // everytime, because we're using datatable a lot - it make sense

            var ScannedAddresses = new DataTable();
            ScannedAddresses.Columns.Add("Address", typeof(string));
            ScannedAddresses.Columns.Add("Value", typeof(string));
            ScannedAddresses.Columns.Add("Previous", typeof(string));

            //ScannedAddresses.Rows.Add("address", "value", "previous");

            GridControlScannedAddresses.DataSource = ScannedAddresses;
            GridViewScannedAddresses.Columns[0].OptionsFilter.AllowFilter = false;

            var ModifiedValues = new DataTable();
            ModifiedValues.Columns.Add("Active", typeof(bool));
            ModifiedValues.Columns.Add("Description", typeof(string));
            ModifiedValues.Columns.Add("Address", typeof(string));
            ModifiedValues.Columns.Add("Type", typeof(string));
            ModifiedValues.Columns.Add("Value", typeof(string));
            //ModifiedValues.Columns.Add("Previous", typeof(string));
            // ModifiedValues.Columns.Add("Previous", typeof(string));

            // ModifiedValues.Rows.Add("address", "value", "previous");

            GridControlModifyValues.DataSource = ModifiedValues;
        }
    }
}