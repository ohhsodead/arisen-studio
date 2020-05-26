using System.IO;

namespace ModioX.Extensions
{
    internal static class StringExtensions
    {
        public static string ReplaceInvalidChars(string filename)
        {
            return string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
        }
    }
}