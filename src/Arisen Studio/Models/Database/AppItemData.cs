using System.Collections.Generic;
using System.Linq;
using System;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace ArisenStudio.Models.Database
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

        public IEnumerable<string> Creators => CreatedBy.Split(['/', '&']).Select(x => x.Trim());
        
        public List<string> Versions => Version.Split('/').ToList();
        
        public List<string> FirmwareVersions => PlayableVersion.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

        public Platform GetPlatform()
        {
            return ArisenStudio.Platform.PS4;
        }

        public string GetVersion(AppItemFile appFile)
        {
            return appFile.Version.IsNullOrEmpty() ? string.Empty : appFile.Version;
        }

        /// <summary>
        /// Get the category data.
        /// </summary>
        /// <param name="categoriesData"> </param>
        /// <returns> </returns>
        public CategoryItem GetCategory(CategoriesData categoriesData)
        {
            return categoriesData.Categories.FirstOrDefault(x => x.Id.EqualsIgnoreCase(CategoryId)) ?? new CategoryItem() { Title = "<Can't Find Name>" };
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
            return $@"{MainWindow.Settings.PathDownloads.GetFullPath(MainWindow.Settings.PathAppData)}\{Platform}\Homebrew\{Name.RemoveInvalidChars()}\{CreatedBy.RemoveInvalidChars()}\{appFile.Name.RemoveInvalidChars()}-{GetVersion(appFile)}-{Id}\";
        }

        /// <summary>
        /// Get the downloaded files path.
        /// </summary>
        /// <returns> Mods Archive File Path </returns>
        public string LocalFilePath(AppItemFile appFile)
        {
            return $@"{MainWindow.Settings.PathDownloads.GetFullPath(MainWindow.Settings.PathAppData)}\{Platform}\Homebrew\{Name.RemoveInvalidChars()}\{CreatedBy.RemoveInvalidChars()}\{appFile.Name.RemoveInvalidChars()}{GetVersion(appFile)}-{Id}.pkg";
        }

        /// <summary>
        /// Download the modded files archive and extracts all files to <see cref="DownloadDataDirectory" />.
        /// </summary>
        /// <param name="appFile"> </param>
        public async Task DownloadAppFile(AppItemFile appFile, IProgress<int> progress = null)
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
                _ = Directory.CreateDirectory(folderPath);
            }

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Accept: application/zip");
                webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");

                webClient.DownloadProgressChanged += (sender, e) =>
                {
                    progress?.Report(e.ProgressPercentage);
                };

                await webClient.DownloadFileTaskAsync(new Uri(appFile.GetFileUrl(TitleId)), filePath);
            }
        }
    }
}