using System;
using System.Collections.Generic;
using System.Data;

namespace ModioX.Extensions
{
    internal class DataExtensions
    {
        /// <summary>
        /// Get the current logged-in users name.
        /// </summary>
        /// <returns>Current User Name</returns>
        public static string LocalUserName => Environment.UserName.FormatUserName();

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

        public static Type GetDataType(string typeName)
        {
            if (Type.GetType(typeName, false, true) == typeof(int))
            {
                return typeof(int);
            }

            if (Type.GetType(typeName, false, true) == typeof(uint))
            {
                return typeof(uint);
            }

            if (Type.GetType(typeName, false, true) == typeof(bool))
            {
                return typeof(bool);
            }

            if (Type.GetType(typeName, false, true) == typeof(string))
            {
                return typeof(string);
            }

            return typeof(string);
        }
    }

    public class ListItem
    {
        public string Value { get; set; }

        public string Name { get; set; }
    }
}