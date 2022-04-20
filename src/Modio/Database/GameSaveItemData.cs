using Humanizer;
using Modio;
using Modio.Database;
using Modio.Extensions;
using Modio.Forms.Windows;
using Modio.Io;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;

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

    public string CreatedBy { get; set; }

    public string SubmittedBy { get; set; }

    public string Version { get; set; }

    public string GameMode { get; set; }

    public string Description { get; set; }

    public List<GameSaveDownloadFiles> DownloadFiles { get; set; }

    public IEnumerable<string> Creators => CreatedBy.Split(new char[] { '/', '&' }).Select(x => x.Trim());

    public Platform GetPlatform()
    {
        return Platform switch
        {
            "PS3" => Modio.Platform.PS3,
            "XBOX" => Modio.Platform.XBOX360,
            _ => Modio.Platform.PS3
        };
    }

    /// <summary>
    /// Get the directory for extracting modded files.
    /// </summary>
    /// <returns> </returns>
    public string DownloadDataDirectory(GameSaveDownloadFiles downloadFiles)
    {
        return $@"{MainWindow.Settings.PathGameMods.GetFullPath(MainWindow.Settings.PathBaseDirectory)}\{Platform.Humanize()}\{Name.RemoveInvalidChars()}\{CreatedBy.RemoveInvalidChars()}\{downloadFiles.Name.RemoveInvalidChars()}-{Version}-{Id}\";
    }

    /// <summary>
    /// Get the downloaded mods archive file path.
    /// </summary>
    /// <returns> Mods Archive File Path </returns>
    public string ArchiveZipFile(GameSaveDownloadFiles downloadFiles)
    {
        return $@"{MainWindow.Settings.PathGameSaves.GetFullPath(MainWindow.Settings.PathBaseDirectory)}\{Platform.Humanize()}\{Name.RemoveInvalidChars()}\{CreatedBy.RemoveInvalidChars()}\{downloadFiles.Name.RemoveInvalidChars()}-{Version}-{Id}.zip";
    }

    /// <summary>
    /// Download the modded files archive and extracts all files to <see cref="DownloadDataDirectory" />.
    /// </summary>
    /// <param name="downloadFiles"> </param>
    public void DownloadInstallFiles(GameSaveDownloadFiles downloadFiles)
    {
        string archivePath = DownloadDataDirectory(downloadFiles);
        string archiveFilePath = ArchiveZipFile(downloadFiles);

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
            webClient.DownloadFile(new Uri(downloadFiles.Url), archiveFilePath);
        }

        ZipFile.ExtractToDirectory(archiveFilePath, archivePath);
    }
}