namespace ModioX.Models.Database
{
    public partial class BackupFile
    {
        public string Name { get; set; }
        public string File { get; set; }
        public string GameId { get; set; }
        public string LocalPath { get; set; } = @"path_to_local_file";
        public string InstallPath { get; set; } = "/dev_hdd0/...";
    }
}