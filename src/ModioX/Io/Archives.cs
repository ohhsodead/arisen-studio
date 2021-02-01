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

            using var zipArchive = ZipFile.Open(zipPath, ZipArchiveMode.Update);
            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                zipArchive.CreateEntryFromFile(fileInfo.FullName, fileInfo.Name);
            }
        }
    }
}