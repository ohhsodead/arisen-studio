using Humanizer;
using ArisenStudio;
using ArisenStudio.Database;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Io;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;

/// <summary>
/// Get the game trainer information.
/// </summary>
public class TrainerItem
{
    public string TitleId { get; set; }

    public string Description { get; set; }

    public List<TrainerData> Trainers { get; set; }

    public Platform GetPlatform()
    {
        return Platform.XBOX360;
    }

    /// <summary>
    /// Get the directory for extracting the files.
    /// </summary>
    /// <returns> </returns>
    public string DownloadDataDirectory(TrainerData trainerData)
    {
        return $@"{MainWindow.Settings.PathGameMods.GetFullPath(MainWindow.Settings.PathBaseDirectory)}\{GetPlatform().Humanize()}\{TitleId.RemoveInvalidChars()}\{trainerData.Name.RemoveInvalidChars()}\";
    }

    /// <summary>
    /// Get the downloaded archive file path.
    /// </summary>
    /// <returns> Archive File Path </returns>
    public string ArchiveZipFile(TrainerData trainerData)
    {
        return $@"{MainWindow.Settings.PathGameSaves.GetFullPath(MainWindow.Settings.PathBaseDirectory)}\{GetPlatform().Humanize()}\{TitleId.RemoveInvalidChars()}\{trainerData.Name.RemoveInvalidChars()}.zip";
    }

    /// <summary>
    /// Download the archive and extracts all files to <see cref="DownloadDataDirectory" />.
    /// </summary>
    /// <param name="trainerData"> </param>
    public void DownloadInstallFiles(TrainerData trainerData)
    {
        string archivePath = DownloadDataDirectory(trainerData);
        string archiveFilePath = ArchiveZipFile(trainerData);

        if (Directory.Exists(archivePath))
        {
            UserFolders.DeleteDirectory(archivePath);
        }

        if (!Directory.Exists(archivePath))
        {
            Directory.CreateDirectory(archivePath);
        }

        if (File.Exists(archiveFilePath))
        {
            File.Delete(archiveFilePath);
        }

        using (WebClient webClient = new())
        {
            webClient.Headers.Add("Accept: application/zip");
            webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
            webClient.DownloadFile(new Uri(trainerData.Url), archiveFilePath);
        }

        ZipFile.ExtractToDirectory(archiveFilePath, archivePath);
    }

    public class TrainerData
    {
        public DateTime LastUpdated { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Url { get; set; }

        public string[] InstallPaths { get; set; }
    }
}