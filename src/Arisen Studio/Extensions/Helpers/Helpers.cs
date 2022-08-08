using DevExpress.XtraEditors;
using ArisenStudio.Forms.Windows;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using XDevkit;

namespace ArisenStudio.Extensions
{
    public static class Helpers
    {
        public static void ScanForXboxConsoles(Form owner)
        {
            try
            {
                XboxManager xboxManager = new();

                int count = 0;

                foreach (string xbox in xboxManager.Consoles)
                {
                    if (MainWindow.Settings.ConsoleProfiles.Exists(x => x.Platform == Platform.XBOX360 && x.Name.Equals(xbox)))
                    {
                        if (XtraMessageBox.Show(owner, $"A console name: {xbox} already exists in your profiles.\n\nWould you like to it again?", "Duplicate Console", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            MainWindow.Settings.ConsoleProfiles.Add(
                                new()
                                {
                                    Name = xbox,
                                    Address = xbox,
                                    PlatformType = PlatformType.Xbox360EliteFatBlack,
                                    Platform = Platform.XBOX360
                                });

                            count++;
                        }
                    }
                    else
                    {
                        MainWindow.Settings.ConsoleProfiles.Add(
                               new()
                               {
                                   Name = xbox,
                                   Address = xbox,
                                   PlatformType = PlatformType.Xbox360EliteFatBlack,
                                   Platform = Platform.XBOX360
                               });

                        count++;
                    }
                }

                XtraMessageBox.Show(owner, $"A total of {count} consoles were added to your profiles.", MainWindow.ResourceLanguage.GetString("XBOX_CONSOLES"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MainWindow.Window.SetStatus("Unable to scan for Xbox consoles.", ex);
                XtraMessageBox.Show(owner, $"Unable to scan for Xbox consoles.\n\nError: {ex.Message}", MainWindow.ResourceLanguage.GetString("XBOX_CONSOLES"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static ListItem GetXboxProfileFile(IXboxConsole xboxConsole, Form owner)
        {
            List<ListItem> consoleProfiles = new();
            List<string> consoleProfilesPaths = new();

            IXboxFiles xboxFiles = xboxConsole.DirectoryFiles(@"Hdd:\Content\");

            foreach (IXboxFile file in xboxFiles)
            {
                if (file.IsDirectory)
                {
                    MessageBox.Show(file.Name);

                    if (!file.Name.Contains("0000000000000000"))
                    {
                        consoleProfilesPaths.Add(file.Name);
                    }
                }
            }

            foreach (string profile in consoleProfilesPaths)
            {
                string profilePath = @$"Hdd:\Content\{profile.Replace(@"Hdd:\Content\", string.Empty)}\FFFE07D1\00010000\";

                try
                {
                    foreach (IXboxFile file in xboxConsole.DirectoryFiles(profilePath))
                    {
                        if (!file.IsDirectory)
                        {
                            string profileName = profile.Replace(@"Hdd:\Content\", string.Empty).Replace(@"\FFFE07D1\00010000\", string.Empty);

                            consoleProfiles.Add(new()
                            {
                                Name = profileName,
                                Value = file.Name
                            });
                        }
                    }
                }
                catch
                {
                    // Profile file doesn't exist, so skip to next one
                    continue;
                }
            }

            if (consoleProfiles.Count > 0)
            {
                return DialogExtensions.ShowListViewDialog(owner, "Choose Profile", consoleProfiles);
            }
            else
            {
                return null;
            }
        }
    }
}
