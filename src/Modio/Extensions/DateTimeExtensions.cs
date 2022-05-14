using System;
using System.Globalization;

namespace Modio.Extensions
{
    internal static class DateTimeExtensions
    {
        public static bool IsValidDate(this string value, string dateFormat)
        {
            return DateTime.TryParseExact(value, dateFormat, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None, out _);
        }
    }
}