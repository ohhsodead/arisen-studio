using Humanizer;
using ArisenStudio;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;

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
    public void DownloadInstallFiles(TrainerItem trainerData)
    {
        string archivePath = DownloadDataDirectory(trainerData);
        string archiveFilePath = ArchiveZipFile(trainerData);

        try
        {
            if (Directory.Exists(archivePath))
            {
                Directory.Delete(archivePath, true);
            }
        }
        catch (Exception) { }

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

        using (WebClient webClient = new())
        {
            webClient.Headers.Add("Accept: application/zip");
            webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
            webClient.DownloadFile(new Uri(trainerData.Url), archiveFilePath);
        }

        ZipFile.ExtractToDirectory(archiveFilePath, archivePath);
        //ZipFile.ExtractToDirectory(archiveFilePath, archivePath, Encoding.UTF8);

        //try
        //{
        //    //Declare a temporary path to unzip your files
        //    string tempPath = Path.Combine(Directory.GetCurrentDirectory(), "tempUnzip");
        //    ZipFile.ExtractToDirectory(archiveFilePath, tempPath);

        //    //build an array of the unzipped files
        //    string[] files = Directory.GetFiles(tempPath);

        //    foreach (string file in files)
        //    {
        //        FileInfo f = new FileInfo(file);
        //        //Check if the file exists already, if so delete it and then move the new file to the extract folder
        //        if (File.Exists(Path.Combine(archivePath, f.Name)))
        //        {
        //            File.Delete(Path.Combine(archivePath, f.Name));
        //            File.Move(f.FullName, Path.Combine(archivePath, f.Name));
        //        }
        //        else
        //        {
        //            File.Move(f.FullName, Path.Combine(archivePath, f.Name));
        //        }
        //    }
        //    //Delete the temporary directory.
        //    Directory.Delete(tempPath);
        //}
        //catch (Exception ex)
        //{
        //    Program.Log.Error("Unable to unzip archive. Error: " + ex.Message);
        //}
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