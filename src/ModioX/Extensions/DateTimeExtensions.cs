using System;
using System.Globalization;
using ModioX.Net;

namespace ModioX.Extensions
{
    internal static class DateTimeExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="time"> </param>
        /// <returns> </returns>
        public static DateTime? ToDateTime(this WINAPI.FILETIME time)
        {
            switch (time.dwHighDateTime)
            {
                case 0 when time.dwLowDateTime == 0:
                case 0 when time.dwLowDateTime == 0:
                    return null;
                default:
                    unchecked
                    {
                        uint low = (uint)time.dwLowDateTime;
                        long ft = ((long)time.dwHighDateTime << 32) | low;
                        return DateTime.FromFileTimeUtc(ft);
                    }
            }
        }

        public static bool IsValidDate(this string value, string dateFormat)
        {
            return DateTime.TryParseExact(value, dateFormat, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None, out _);
        }
    }
}