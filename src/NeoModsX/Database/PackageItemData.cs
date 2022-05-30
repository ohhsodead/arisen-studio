using NeoModsX.Extensions;

namespace NeoModsX.Database
{
    /// <summary>
    /// Get Package Information.
    /// </summary>
    public class PackageItemData
    {
        public string Category { get; set; }

        public string TitleId { get; set; }

        public string Region { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public string Rap { get; set; }

        public string ContentId { get; set; }

        public string ModifiedDate { get; set; }

        public string DownloadRap { get; set; }

        public string Size { get; set; }

        public string Sha256 { get; set; }

        public string InstallFilePathPKG => $"/dev_hdd0/packages/{Name.RemoveInvalidChars()}.pkg";

        public string InstallFilePathRAP => $"/dev_hdd0/exdata/{ContentId.RemoveInvalidChars()}.rap";

        public bool IsNameMissing => Name.IsNullOrEmpty();

        public bool IsUrlMissing => Url.IsNullOrEmpty();

        public bool IsRapRequired => !Rap.Equals("NOT REQUIRED");

        public bool IsRapMissing => Rap.Equals("MISSING") | Rap.IsNullOrEmpty();

        public bool IsDateMissing => ModifiedDate.IsNullOrEmpty();

        public bool IsSizeMissing => Size.IsNullOrEmpty();

        public bool IsSha256Missing => Sha256.IsNullOrEmpty();

        public string RapUrl => $"https://nopaystation.com/tools/rap2file/{ContentId}/{Rap}";
    }
}