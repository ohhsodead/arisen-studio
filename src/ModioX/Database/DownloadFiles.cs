using System.Collections.Generic;
using System.Linq;

namespace ModioX.Database
{
    public class DownloadFiles
    {
        public string Name { get; set; }

        public string URL { get; set; }

        public List<string> InstallPaths { get; set; }

        /// <summary>
        /// Check whether any files are being installed to a game folder.
        /// </summary>
        public bool RequiresGameRegion => InstallPaths.Any(x => x.Contains("{REGION}"));

        /// <summary>
        /// Check whether any files are being installed to a profile user's folder.
        /// </summary>
        public bool RequiresUserId => InstallPaths.Any(x => x.Contains("{USERID}"));

        /// <summary>
        /// Check whether any files are being installed to a USB device.
        /// </summary>
        public bool RequiresUsbDevice => InstallPaths.Any(x => x.Contains("{USBDEV}"));

        /// <summary>
        /// Check whether any files are installed at the 'dev_rebug' (firmware) folder.
        /// </summary>
        /// <returns> </returns>
        public bool InstallsToRebugFolder => InstallPaths.Any(x => x.StartsWith("/dev_rebug/"));
    }
}