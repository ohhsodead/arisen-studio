using System.Collections.Generic;
using System.Data;

namespace ModioX.Extensions
{
    internal class DataExtensions
    {
        /// <summary>
        /// Create and return a new DataTable with the specified columns and rows.
        /// </summary>
        /// <param name="columns"> Columns to add to the DataTable </param>
        /// <param name="rows"> Rows to add to the DataTable </param>
        public static DataTable CreateDataTable(List<DataColumn> columns, List<DataRow> rows = null)
        {
            DataTable dataTable = new();

            dataTable.Columns.AddRange(columns.ToArray());

            if (rows != null)
            {
                foreach (DataRow row in rows)
                {
                    dataTable.Rows.Add(row);
                }
            }

            return dataTable;
        }
    }

    public class ListItem
    {
        public string Value { get; set; }

        public string Name { get; set; }
    }
}