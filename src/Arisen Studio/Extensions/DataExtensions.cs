using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace ArisenStudio.Extensions
{
    internal class DataExtensions
    {
        public static byte[] GetData(byte[] Source, int Offset, int Count)
        {
            var dest = new byte[Count];
            Buffer.BlockCopy(Source, Offset, dest, 0, Count);
            return dest;
        }

        public static double ComputePercentage(long Current, long Total) { return (double)Current * 100 / Total; }

        public static string ByteArrayToString(byte[] ByteArray) { return BitConverter.ToString(ByteArray).Replace("-", string.Empty); }

        public static byte[] ReadAllBytes(Stream Stream)
        {
            Stream.Position = 0;
            var stream = Stream as MemoryStream;
            if (stream != null) return stream.ToArray();
            using (var ms = new MemoryStream())
            {
                Stream.CopyTo(ms, 0x2000);
                ms.Flush();
                return ms.ToArray();
            }
        }

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

        public static int GenerateUniqueId()
        {
            //List<int?> ids =
            //[
            //    .. from ConsoleProfile console in MainWindow.Settings.ConsoleProfiles select console.Id,
            //];

            //Random rndm = new();

            //int id;

            //do
            //{
            //    id = rndm.Next(0, 1000000);
            //}
            //while (ids.Contains(id));

            //return id;

            List<int?> ids = MainWindow.Settings.ConsoleProfiles.Select(console => console.Id).ToList();

            Random rndm = new();
            int id;

            do
            {
                id = rndm.Next(0, 1000000);
            }
            while (ids.Contains(id));

            return id;
        }
    }

    public class ListItem
    {
        public string Value { get; set; }

        public string Name { get; set; }
    }

    public class InstallItem
    {
        public string LocalFilePath { get; set; }

        public string InstallFilePath { get; set; }
    }
}