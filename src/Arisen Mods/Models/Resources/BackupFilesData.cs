using ArisenMods.Database;
using ArisenMods.Extensions;
using ArisenMods.Forms.Windows;
using ArisenMods.Io;
using ArisenMods.Models.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ArisenMods.Models.Resources
{
    public class BackupFilesData
    {
        public List<BackupFile> BackupFiles { get; set; } = new();

        /// <summary>
        /// Create/store a backup of the specified file, and then downloads it locally to a known path
        /// </summary>
        /// <param name="modItem"> </param>
        /// <param name="fileName"> </param>
        /// <param name="installFilePath"> </param>
        public void CreateBackupFile(ModItemData modItem, string fileName, string installFilePath)
        {
            string gameBackupFolder = GetGameBackupFolder(modItem);

            Directory.CreateDirectory(gameBackupFolder);

            BackupFile backupFile = new()
            {
                Platform = modItem.GetPlatform(),
                CategoryId = modItem.CategoryId,
                FileName = fileName,
                LocalPath = Path.Combine(gameBackupFolder, fileName),
                InstallPath = installFilePath,
                CreatedDate = DateTime.Now
            };

            MainWindow.FtpClient.DownloadFile(backupFile.LocalPath, backupFile.InstallPath);
            BackupFiles.Add(backupFile);
        }

        /// <summary>
        /// Gets the <see cref="BackupFile" /> information for the specified game id, file name and
        /// install path
        /// </summary>
        /// <param name="gameId"> Game Id </param>
        /// <param name="fileName"> File Name </param>
        /// <param name="installPath"> File Install Path </param>
        /// <returns> </returns>
        public BackupFile GetGameFileBackup(Platform platform, string gameId, string fileName, string installPath)
        {
            return
                BackupFiles.FirstOrDefault(backupFile =>
                backupFile.Platform == platform &&
                backupFile.CategoryId.EqualsIgnoreCase(gameId) &&
                backupFile.FileName.ContainsIgnoreCase(fileName) &&
                backupFile.InstallPath.ContainsIgnoreCase(installPath));
        }

        /// <summary>
        /// Create and return the game backup files folder for the specified <see cref="ModsData.ModItem" />
        /// </summary>
        /// <param name="modItem"> </param>
        /// <returns> </returns>
        public string GetGameBackupFolder(ModItemData modItem)
        {
            return Path.Combine(UserFolders.BackupFiles, modItem.CategoryId);
        }

        /// <summary>
        /// Updates the collection of backup files at index if it's exists, otherwise adds a new one.
        /// </summary>
        /// <param name="index"> </param>
        /// <param name="backupFile"> </param>
        public void UpdateBackupFile(int? index, BackupFile backupFile)
        {
            if (index == null)
            {
                BackupFiles.Add(backupFile);
            }
            else
            {
                BackupFiles[index.Value] = backupFile;
            }
        }
    }

    /// <summary>
    /// Create a backup file class with the details.
    /// </summary>
    public class BackupFile
    {
        public Platform Platform { get; set; }

        public string CategoryId { get; set; }

        public string FileName { get; set; }

        public string LocalPath { get; set; }

        public string InstallPath { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}