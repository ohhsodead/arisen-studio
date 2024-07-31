using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Database;
using ArisenStudio.Models.Resources;
using System;
using System.Collections.Generic;
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

        public string GetVersion(AppItemFile appFile)
        {
            if (appFile.Version.IsNullOrEmpty())
            {
                return string.Empty;
            }
            else
            {
                return appFile.Version;
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
        /// Get the directory for extracting modded files.
        /// </summary>
        /// <returns> </returns>
        public string DownloadFilesDirectory(AppItemFile appFile)
        {
            return $@"{MainWindow.Settings.PathGameMods.GetFullPath(MainWindow.Settings.PathBaseDirectory)}\{Platform}\{Name.RemoveInvalidChars()}\{CreatedBy.RemoveInvalidChars()}\{appFile.Name.RemoveInvalidChars()}-{GetVersion(appFile)}-{Id}\";
        }

        /// <summary>
        /// Get the downloaded files path.
        /// </summary>
        /// <returns> Mods Archive File Path </returns>
        public string LocalFilePath(AppItemFile appFile)
        {
            return $@"{MainWindow.Settings.PathGameMods.GetFullPath(MainWindow.Settings.PathBaseDirectory)}\{Platform}\{Name.RemoveInvalidChars()}\{CreatedBy.RemoveInvalidChars()}\{appFile.Name.RemoveInvalidChars()}{GetVersion(appFile)}-{Id}.pkg";
        }

        /// <summary>
        /// Download the modded files archive and extracts all files to <see cref="DownloadDataDirectory" />.
        /// </summary>
        /// <param name="appFile"> </param>
        public void DownloadInstallFiles(AppItemFile appFile)
        {
            string folderPath = DownloadFilesDirectory(appFile);
            string filePath = LocalFilePath(appFile);

            if (Directory.Exists(folderPath))
            {
                try
                {
                    Directory.Delete(folderPath, true);
                }
                catch (Exception) { }
            }

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!Directory.Exists(Path.GetDirectoryName(folderPath)))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            using (WebClient webClient = new())
            {
                //webClient.Headers.Add("Accept: application/zip");
                webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                webClient.DownloadFile(new Uri(appFile.GetFileUrl(TitleId)), filePath);
            }

            /*
            DownloadedItem downloadItem = MainWindow.Settings.DownloadedMods.FirstOrDefault(x => x.Platform == GetPlatform() && x.ModId == Id);
            
            if (downloadItem == null)
            {
                MainWindow.Settings.DownloadedMods.Add(
                    new DownloadedItem()
                    {
                        Platform = GetPlatform(),
                        ModId = Id,
                        CategoryId = CategoryId,
                        DownloadFile = appFile,
                        FilePath = filePath,
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
            */
        }
    }
}