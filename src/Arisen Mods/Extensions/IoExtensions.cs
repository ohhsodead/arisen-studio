namespace ArisenMods.Extensions
{
    internal static class IoExtensions
    {
        public static string GetFullPath(this string basePath, string path)
        {
            return basePath.Replace("%BASE_DIR%", path);
        }
    }
}