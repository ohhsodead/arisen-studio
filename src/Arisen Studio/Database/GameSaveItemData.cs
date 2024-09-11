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
using ArisenStudio.Models.Database;

/// <summary>
/// Get the game save information.
/// </summary>
public class GameSaveItemData
{
    public string Platform { get; set; }

    public int Id { get; set; }

    public string CategoryId { get; set; }

    public string Name { get; set; }

    public string Region { get; set; }

    public DateTime LastUpdated { get; set; }

    public string CreatedBy { get; set; }

    public string SubmittedBy { get; set; }

    public string Version { get; set; }

    public string GameMode { get; set; }

    public string Description { get; set; }

    public List<DownloadFiles> DownloadFiles { get; set; }

    public IEnumerable<string> Creators => CreatedBy.Split(['/', '&']).Select(x => x.Trim());

    public Platform GetPlatform()
    {
        return Platform switch
        {
            "PS3" => ArisenStudio.Platform.PS3,
            "XBOX" => ArisenStudio.Platform.XBOX360,
            "PS4" => ArisenStudio.Platform.PS4,
            _ => ArisenStudio.Platform.PS3
        };
    }

    /// <summary>
    /// Get the directory for extracting modded files.
    /// </summary>
    /// <returns> </returns>
    public string DownloadDataDirectory(DownloadFiles downloadFiles, Category category)
    {
        return $@"{MainWindow.Settings.PathDownloads.GetFullPath(MainWindow.Settings.PathAppData)}\{Platform.Humanize()}\Game Saves\{category.Title}\{Name.RemoveInvalidChars()}\{CreatedBy.RemoveInvalidChars()}\{downloadFiles.Name.RemoveInvalidChars()}-{Version}-{Id}\";
    }

    /// <summary>
    /// Get the downloaded mods archive file path.
    /// </summary>
    /// <returns> Mods Archive File Path </returns>
    public string ArchiveZipFile(DownloadFiles downloadFiles, Category category)
    {
        return $@"{MainWindow.Settings.PathDownloads.GetFullPath(MainWindow.Settings.PathAppData)}\{Platform.Humanize()}\Game Saves\{category.Title}\{Name.RemoveInvalidChars()}\{CreatedBy.RemoveInvalidChars()}\{downloadFiles.Name.RemoveInvalidChars()}-{Version}-{Id}.zip";
    }

    /// <summary>
    /// Download the modded files archive and extracts all files to <see cref="DownloadDataDirectory" />.
    /// </summary>
    /// <param name="downloadFiles"> </param>
    public void DownloadInstallFiles(DownloadFiles downloadFiles, Category category)
    {
        string archivePath = DownloadDataDirectory(downloadFiles, category);
        string archiveFilePath = ArchiveZipFile(downloadFiles, category);

        if (Directory.Exists(archivePath))
        {
            IoExtensions.DeleteDirectory(archivePath);
        }

        if (!Directory.Exists(archivePath))
        {
            _ = Directory.CreateDirectory(archivePath);
        }

        if (File.Exists(archiveFilePath))
        {
            File.Delete(archiveFilePath);
        }

        using (WebClient webClient = new())
        {
            webClient.Headers.Add("Accept: application/zip");
            webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
            webClient.DownloadFile(new Uri(downloadFiles.Url), archiveFilePath);
        }

        ZipFile.ExtractToDirectory(archiveFilePath, archivePath);
    }
}