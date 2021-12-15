using System.Collections.Generic;
using System.IO;

namespace ModioX.Extensions
{
    internal static class UsbExtensions
    {
        public static List<ListItem> GetUsbDevices()
        {
            List<ListItem> usbDevices = new();

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Removable && drive.IsReady)
                {
                    usbDevices.Add(new() { Name = drive.VolumeLabel, Value = drive.Name });
                }
            }

            return usbDevices;
        }
    }
}