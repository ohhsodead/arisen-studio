using System.IO;
using System;

namespace ArisenStudio.Extensions
{
    internal static class IoExtensions
    {
        public static string GetFullPath(this string appData, string path, string platform = "", string category = "")
        {
            return appData.Contains("%APPDATA%")
                ? appData
                .Replace("%APPDATA%", path)
                .Replace("%PLATFORM%", platform)
                .Replace("%CATEGORY%", category)
                : appData;
        }

        /// <summary>
        /// Depth-first recursive delete, with handling for descendant 
        /// directories open in Windows Explorer.
        /// </summary>
        public static void DeleteDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                return;
            }

            DirectoryInfo dir = new(path);

            try
            {
                foreach (DirectoryInfo subdir in dir.GetDirectories())
                {
                    subdir.Delete(true);
                }

                dir.Delete(true);
            }
            catch (IOException ex)
            {
                Program.Log.Warn(ex);
                Directory.Delete(path, true);
            }
            catch (Exception ex)
            {
                Program.Log.Warn(ex);
                switch (ex)
                {
                    case UnauthorizedAccessException:
                    case DirectoryNotFoundException:
                        return;
                }
            }
        }

        public static string GetNextFileName(string fileName)
        {
            string extension = Path.GetExtension(fileName);

            int i = 0;
            while (File.Exists(fileName))
            {
                fileName = i == 0 ? fileName.Replace(extension, "-" + ++i + extension) : fileName.Replace("-" + i + extension, "-" + ++i + extension);
            }

            return fileName;
        }
    }
}