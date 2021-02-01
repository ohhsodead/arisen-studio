using System.IO;
using System.IO.Compression;

namespace ModioX.Io
{
    public static class Archives
    {
        /// <summary>
        /// Copy files to the the archive ZIP file
        /// </summary>
        /// <param name="zipPath"> </param>
        /// <param name="files"> </param>
        public static void AddFilesToZip(string zipPath, string[] files)
        {
            if (files == null || files.Length == 0)
            {
                return;
            }

            using ZipArchive zipArchive = ZipFile.Open(zipPath, ZipArchiveMode.Update);
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                zipArchive.CreateEntryFromFile(fileInfo.FullName, fileInfo.Name);
            }
        }
    }
}