using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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

        /// <summary>
        /// Get a byte array from a hex string.
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        public static Type GetDataType(string typeName)
        {
            if (Type.GetType(typeName, false, true) == typeof(int))
            {
                return typeof(int);
            }
            else if (Type.GetType(typeName, false, true) == typeof(uint))
            {
                return typeof(uint);
            }
            else if (Type.GetType(typeName, false, true) == typeof(bool))
            {
                return typeof(bool);
            }
            else if (Type.GetType(typeName, false, true) == typeof(string))
            {
                return typeof(string);
            }
            else
            {
                return typeof(string);
            }
        }
    }

    public class ListItem
    {
        public string Value { get; set; }

        public string Name { get; set; }
    }
}