using ModioX.Net;
using System;

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
            if (time.dwHighDateTime == 0 && time.dwLowDateTime == 0)
            {
                return null;
            }

            if (time.dwHighDateTime == 0 && time.dwLowDateTime == 0) return null;

            unchecked
            {
                var low = (uint)time.dwLowDateTime;
                var ft = ((long)time.dwHighDateTime << 32) | low;
                return DateTime.FromFileTimeUtc(ft);
            }
        }
    }
}