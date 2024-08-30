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
            foreach (string directory in Directory.GetDirectories(path))
            {
                DeleteDirectory(directory);
            }

            try
            {
                Directory.Delete(path, true);
            }
            catch (IOException)
            {
                Directory.Delete(path, true);
            }
            catch (UnauthorizedAccessException)
            {
                Directory.Delete(path, true);
            }
        }
    }
}