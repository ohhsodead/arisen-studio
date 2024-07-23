using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Database;
using ArisenStudio.Models.Resources;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace ArisenStudio.Database
{

    public partial class AppItemData
    {
        public string Platform { get; set; }

        public int Id { get; set; }

        public string CategoryId { get; set; }

        public string Name { get; set; }

        public string CreatedBy { get; set; } = "Unknown";

        public string SubmittedBy { get; set; }

        public string Version { get; set; }

        public string PlayableVersion { get; set; }

        public string ContentId { get; set; }

        public string TitleId { get; set; }

        public string Description { get; set; }

        public List<AppItemFile> DownloadFiles { get; set; }

        public Platform GetPlatform()
        {
            return ArisenStudio.Platform.PS4;
        }

        public string GetVersion(DownloadFiles downloadFiles)
        {
            if (downloadFiles.Version.IsNullOrEmpty())
            {
                return string.Empty;
            }
            else
            {
                return downloadFiles.Version;
            }
        }

        public IEnumerable<string> Creators => CreatedBy.Split(['/', '&']).Select(x => x.Trim());

        public List<string> Versions => [.. Version.Split('/')];

        public List<string> FirmwareVersions => [.. PlayableVersion.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)];

        /// <summary>
        /// Get the category data.
        /// </summary>
        /// <param name="categoriesData"> </param>
        /// <returns> </returns>
        public Category GetCategory(CategoriesData categoriesData)
        {
            return categoriesData.Categories.FirstOrDefault(x => x.Id.EqualsIgnoreCase(CategoryId)) ?? new Category() { Title = "<Can't Find Name>" };
        }

        /// <summary>
        /// Get the category type.
        /// </summary>
        /// <param name="categoriesData"> </param>
        /// <returns> </returns>
        public CategoryType GetCategoryType(CategoriesData categoriesData)
        {
            return categoriesData.Categories.FirstOrDefault(x => x.Id.EqualsIgnoreCase(CategoryId))?.CategoryType ?? CategoryType.Game;
        }

        /// <summary>
        /// Get the category name.
        /// </summary>
        /// <param name="categoriesData"> </param>
        /// <returns> </returns>
        public string GetCategoryName(CategoriesData categoriesData)
        {
            return categoriesData.Categories.FirstOrDefault(x => x.Id.EqualsIgnoreCase(CategoryId))?.Title ?? "<Can't Find Name>";
        }

        /// <summary>
        /// Get the download URL specified by the user if there are multiple types.
        /// </summary>
        /// <returns> Download Archive URL </returns>
        public AppItemFile GetDownloadFiles(Form owner)
        {
            switch (DownloadFiles.Count)
            {
                case <= 1:
                    return DownloadFiles.First();
            }

            List<string> downloadNames = DownloadFiles.Select(x => x.Name).ToList();
            ListItem downloadName = DialogExtensions.ShowListViewDialog(owner, "Install Downloads", downloadNames.ConvertAll(x => new ListItem { Value = x, Name = x }));

            return downloadName != null ? DownloadFiles.First(x => x.Name.Equals(downloadName.Value)) : null;
        }

        /// <summary>
        /// Get the directory for extracting modded files.
        /// </summary>
        /// <returns> </returns>
        public string DownloadDataDirectory(DownloadFiles downloadFiles)
        {
            return $@"{MainWindow.Settings.PathGameMods.GetFullPath(MainWindow.Settings.PathBaseDirectory)}\{Platform}\{Name.RemoveInvalidChars()}\{CreatedBy.RemoveInvalidChars()}\{downloadFiles.Name.RemoveInvalidChars()}-{GetVersion(downloadFiles)}-{Id}\";
        }

        /// <summary>
        /// Get the downloaded mods archive file path.
        /// </summary>
        /// <returns> Mods Archive File Path </returns>
        public string ArchiveZipFile(DownloadFiles downloadFiles)
        {
            return $@"{MainWindow.Settings.PathGameMods.GetFullPath(MainWindow.Settings.PathBaseDirectory)}\{Platform}\{Name.RemoveInvalidChars()}\{CreatedBy.RemoveInvalidChars()}\{downloadFiles.Name.RemoveInvalidChars()}-{GetVersion(downloadFiles)}-{Id}.zip";
        }

        /// <summary>
        /// Download the modded files archive and extracts all files to <see cref="DownloadDataDirectory" />.
        /// </summary>
        /// <param name="downloadFiles"> </param>
        public void DownloadInstallFiles(DownloadFiles downloadFiles)
        {
            string archivePath = DownloadDataDirectory(downloadFiles);
            string archiveFilePath = ArchiveZipFile(downloadFiles);

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
                Directory.CreateDirectory(archivePath);
            }

            if (!Directory.Exists(Path.GetDirectoryName(archiveFilePath)))
            {
                Directory.CreateDirectory(archiveFilePath);
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

            DownloadedItem downloadItem = MainWindow.Settings.DownloadedMods.FirstOrDefault(x => x.Platform == GetPlatform() && x.ModId == Id);

            if (downloadItem == null)
            {
                MainWindow.Settings.DownloadedMods.Add(
                    new DownloadedItem()
                    {
                        Platform = GetPlatform(),
                        ModId = Id,
                        CategoryId = CategoryId,
                        DownloadFile = downloadFiles,
                        FilePath = archiveFilePath,
                        DateTime = DateTime.Now
                    });
            }
            else
            {
                MainWindow.Settings.DownloadedMods[MainWindow.Settings.DownloadedMods.IndexOf(downloadItem)] =
                    new DownloadedItem()
                    {
                        Platform = GetPlatform(),
                        ModId = Id,
                        CategoryId = CategoryId,
                        DownloadFile = downloadFiles,
                        FilePath = archiveFilePath,
                        DateTime = DateTime.Now
                    };
            }
        }
    }
}