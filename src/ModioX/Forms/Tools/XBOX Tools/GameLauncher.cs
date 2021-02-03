using System;
using DevExpress.XtraEditors;
using ModioX.Forms.Windows;
﻿using FluentFTP;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using XDevkit;

namespace ModioX.Forms.Tools.XBOX_Tools
{
    public partial class GameLauncher : XtraForm
    {
        public static IXboxConsole XboxConsole { get; } = MainWindow.XboxConsole;

        /// <summary>
        /// Get the FTP connection for use with uploading mods, not reliable for uploading files.
        /// </summary>
        public static FtpConnection FtpConnection { get; } = MainWindow.FtpConnection;

        /// <summary>
        /// Get the FtpClient for getting directory listings and some other commands.
        /// </summary>
        public static FtpClient FtpClient { get; } = MainWindow.FtpClient;

        public GameLauncher()
        {
            InitializeComponent();
        }

        private void GameLauncher_Load(object sender, EventArgs e)
        {
            FtpClient.SetWorkingDirectory("/Hdd1/Games/");

            var folders = new List<FtpListItem>();
            var files = new List<FtpListItem>();

            foreach (var listItem in FtpClient.GetListing("/Hdd1/Games/"))
            {
                switch (listItem.Type)
                {
                    case FtpFileSystemObjectType.Directory:
                        folders.Add(listItem);
                        break;

                    case FtpFileSystemObjectType.File:
                        files.Add(listItem);
                        break;

                    case FtpFileSystemObjectType.Link:
                        break;
                }
            }

            foreach (var listItem in folders)
            {
                ListBoxGames.Items.Add("Folder : " + listItem.Name);
            }

            foreach (var listItem in files)
            {
                ListBoxGames.Items.Add("File : " + listItem.Name);
            }
        }

        private void ButtonFetchGames_Click(object sender, EventArgs e)
        {
        }
    }
}