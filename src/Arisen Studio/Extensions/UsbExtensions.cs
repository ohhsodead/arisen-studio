using System.Collections.Generic;
using System.IO;

namespace ArisenStudio.Extensions
{
    internal static class UsbExtensions
    {
        public static List<ListItem> GetLocalUsbDevices()
        {
            List<ListItem> usbDevices = [];

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Removable && drive.IsReady)
                {
                    usbDevices.Add(new()
                    {
                        Name = drive.VolumeLabel,
                        Value = drive.Name
                    });
                }
            }

            return usbDevices;
        }
    }
}