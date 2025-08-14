using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Resources;
using DevExpress.XtraLayout.Customization;
using Humanizer;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArisenStudio.Models.Database
{
    public class ModItemData
    {
        public string Platform { get; set; }

        public int Id { get; set; }

        public string CategoryId { get; set; }

        public string Name { get; set; }

        public string FirmwareType { get; set; } = "n/a";

        public string Region { get; set; } = "n/a";

        public string CreatedBy { get; set; } = "Unknown";

        public string SubmittedBy { get; set; }

        public string Version { get; set; }

        public string GameMode { get; set; }

        public string ModType { get; set; }

        public string Description { get; set; }

        public List<DownloadFiles> DownloadFiles { get; set; }

        public Platform GetPlatform()
        {
            return Platform switch
            {
                "PS3" => ArisenStudio.Platform.PS3,
                "PS4" => ArisenStudio.Platform.PS4,
                "XBOX" => ArisenStudio.Platform.XBOX360,
                _ => ArisenStudio.Platform.PS3
            };
        }

        public IEnumerable<string> Creators => CreatedBy.Split(['/', '&']).Select(x => x.Trim());

        public List<string> FirmwareTypes => FirmwareType.Split('/').ToList();

        public IEnumerable<string> ModTypes => ModType.Split(['/', '&']).Select(x => x.Trim());

        public IEnumerable<string> Versions
        {
            get
            {
                if (string.IsNullOrEmpty(Version)) return new List<string> { "-" };
                return Version.Split('/').Select(version => version.Trim()).ToList();
            }
        }

        public bool IsAnyRegion => Region.Equals("ALL") || Region.Equals("-");

        public IEnumerable<string> Regions
        {
            get
            {
                return Region.Split('/').Select(region =>
                    region switch
                    {
                        "ALL" => "All Regions",
                        "-" => "n/a",
                        _ => region
                    }).ToList();
            }
        }

        public IEnumerable<string> GameModes
        {
            get
            {
                return GameMode.Split('/').Select(mode =>
                    mode switch
                    {
                        "ALL" => "All Game Modes",
                        "MP" => "Multiplayer",
                        "ZM" => "Zombies",
                        "SP" => "Singleplayer",
                        "CO OP" => "Co-Operative",
                        "SPEC OPS" => "Special Ops",
                        "EXT" => "Extinction",
                        _ => "n/a"
                    }).ToList();
            }
        }

        public string GetVersion(DownloadFiles downloadFiles)
        {
            return string.IsNullOrEmpty(downloadFiles.Version) ? string.Empty : $"-{downloadFiles.Version}";
        }

        public CategoryItem GetCategory(CategoriesData categoriesData)
        {
            return categoriesData.Categories.FirstOrDefault(x => x.Id.EqualsIgnoreCase(CategoryId)) ?? new CategoryItem { Title = "<Can't Find Name>" };
        }

        public CategoryType GetCategoryType(CategoriesData categoriesData)
        {
            return categoriesData.Categories.FirstOrDefault(x => x.Id.EqualsIgnoreCase(CategoryId))?.CategoryType ?? CategoryType.Game;
        }

        public string GetCategoryName(CategoriesData categoriesData)
        {
            return categoriesData.Categories.FirstOrDefault(x => x.Id.EqualsIgnoreCase(CategoryId))?.Title ?? "<Can't Find Name>";
        }

        /// <summary>
        /// Get the download URL specified by the user if there are multiple types.
        /// </summary>
        /// <returns> Download Archive URL </returns>
        public DownloadFiles GetDownloadFiles(Form owner)
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
        public string DownloadDataDirectory(DownloadFiles downloadFiles, CategoryItem category)
        {
            return $@"{MainWindow.Settings.PathDownloads.GetFullPath(MainWindow.Settings.PathAppData)}\{GetPlatform().Humanize()}\{category.CategoryType.Humanize().RemoveInvalidChars()}\{category.Title.RemoveInvalidChars()}\{Name.RemoveInvalidChars()}\{downloadFiles.Name.RemoveInvalidChars()}{GetVersion(downloadFiles)}-{Id}\";
        }

        /// <summary>
        /// Get the downloaded mods archive file path.
        /// </summary>
        /// <returns> Mods Archive File Path </returns>
        public string ArchiveZipFile(DownloadFiles downloadFiles, CategoryItem category)
        {
            return $@"{MainWindow.Settings.PathDownloads.GetFullPath(MainWindow.Settings.PathAppData)}\{GetPlatform().Humanize()}\{category.CategoryType.Humanize().RemoveInvalidChars()}\{category.Title.RemoveInvalidChars()}\{Name.RemoveInvalidChars()}\{downloadFiles.Name.RemoveInvalidChars()}{GetVersion(downloadFiles)}-{Id}.zip";
        }

        /// <summary>
        /// Download the modded files archive and extracts all files to <see cref="DownloadDataDirectory" />.
        /// </summary>
        /// <param name="downloadFiles"> </param>
        public async Task DownloadArchiveFiles(DownloadFiles downloadFiles, CategoryItem category, IProgress<int> progress = null)
        {
            string archivePath = DownloadDataDirectory(downloadFiles, category);
            string archiveFilePath = ArchiveZipFile(downloadFiles, category);

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

                await webClient.DownloadFileTaskAsync(new Uri(downloadFiles.Url), archiveFilePath);
            }

            // Extract the archive file to the archive path
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