using System.IO;
using System.IO.Compression;

namespace ModioX.Io
{
    public class Archives
    {
        /// <summary>
        ///     
        /// </summary>
        /// <param name="zipPath"></param>
        /// <param name="files"></param>
        public static void AddFilesToZip(string zipPath, string[] files)
        {
            if (files == null || files.Length == 0)
            {
                return;
            }

            using (ZipArchive zipArchive = ZipFile.Open(zipPath, ZipArchiveMode.Update))
            {
                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    _ = zipArchive.CreateEntryFromFile(fileInfo.FullName, fileInfo.Name);
                }
            }
        }
    }
}
