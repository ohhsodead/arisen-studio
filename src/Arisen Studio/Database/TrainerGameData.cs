using Humanizer;
using ArisenStudio;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using ArisenStudio.Database;
using System.Threading.Tasks;
using ArisenStudio.Models.Database;

/// <summary>
/// Get the game trainer information.
/// </summary>
public class TrainerGameData
{
    public string TitleId { get; set; }

    public string Description { get; set; }

    public List<TrainerItem> Trainers { get; set; }

    public Platform GetPlatform()
    {
        return Platform.XBOX360;
    }

    /// <summary>
    /// Get the directory for extracting the files.
    /// </summary>
    /// <returns> </returns>
    public string DownloadDataDirectory(TrainerItem trainerData)
    {
        return $@"{MainWindow.Settings.PathDownloads.GetFullPath(MainWindow.Settings.PathAppData)}\{GetPlatform().Humanize()}\Trainers\{TitleId.RemoveInvalidChars()}\{trainerData.Name.RemoveInvalidChars()}\";
    }

    /// <summary>
    /// Get the downloaded archive file path.
    /// </summary>
    /// <returns> Archive File Path </returns>
    public string ArchiveZipFile(TrainerItem trainerData)
    {
        return $@"{MainWindow.Settings.PathDownloads.GetFullPath(MainWindow.Settings.PathAppData)}\{GetPlatform().Humanize()}\Trainers\{TitleId.RemoveInvalidChars()}\{trainerData.Name.RemoveInvalidChars()}.zip";
    }

    /// <summary>
    /// Download the archive and extracts all files to <see cref="DownloadDataDirectory" />.
    /// </summary>
    /// <param name="trainerData"> </param>
    public async Task DownloadArchiveFiles(TrainerItem trainerData, IProgress<int> progress = null)
    {
        string archivePath = DownloadDataDirectory(trainerData);
        string archiveFilePath = ArchiveZipFile(trainerData);

        if (Directory.Exists(archivePath))
        {
            try
            {
                Directory.Delete(archivePath, true);
            }
            catch (Exception) { }
        }

        if (!Directory.Exists(archivePath))
        {
            _ = Directory.CreateDirectory(archivePath);
        }

        if (File.Exists(archiveFilePath))
        {
            File.Delete(archiveFilePath);
        }

        using (WebClient webClient = new WebClient())
        {
            webClient.Headers.Add("Accept: application/zip");
            webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");

            webClient.DownloadProgressChanged += (sender, e) =>
            {
                // Report download progress (0-100)
                progress?.Report(e.ProgressPercentage);
            };

            await webClient.DownloadFileTaskAsync(new Uri(trainerData.Url), archiveFilePath);
        }

        // Extract the archive file to the archive path
        ZipFile.ExtractToDirectory(archiveFilePath, archivePath);
    }
}

    public class TrainerItem
{
    public DateTime LastUpdated { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }

    public string Url { get; set; }

    public string[] InstallPaths { get; set; }

    public new TrainerType GetType()
    {
        if (Type.EqualsIgnoreCase("aurora"))
        {
            return TrainerType.Aurora;
        }
        else
        {
            return TrainerType.Xbdm;
        }
    }
}

public enum TrainerType
{
    Aurora,
    Xbdm,
}