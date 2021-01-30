using DevExpress.XtraEditors;
using IniParser;
using IniParser.Model;
using ModioX.Forms.Windows;
using System;
using System.Drawing;
using System.IO;
using XDevkit;

namespace ModioX.Forms.Tools.XBOX_Tools
{
    public partial class LaunchPluginsEditor : XtraForm
    {
        /// <summary>
        /// Get the xbox console connection.
        /// </summary>
        public static Xbox XboxConsole { get; } = MainWindow.XboxConsole;

        /// <summary>
        /// Get the launch.ini file path located from the console internal hard drive.
        /// </summary>
        private static string LaunchFilePath { get; } = "/Hdd1/launch.ini";

        public LaunchPluginsEditor()
        {
            InitializeComponent();
        }

        private void LaunchPluginsEditor_Load(object sender, EventArgs e)
        {
            comboBoxEdit2.Properties.Items.Clear();

            foreach (string str in XboxConsole.File.Drives.Split(','))
            {
                comboBoxEdit2.Properties.Items.Add(str + @":\");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            XboxConsole.ShutDown();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit2.SelectedIndex == -1)
            {
                comboBoxEdit2.SelectedIndex = 0;
            }
            else
            {
                FileIniDataParser parser = new FileIniDataParser();
                try
                {
                    XboxConsole.File.ReceiveFile(AppDomain.CurrentDomain.BaseDirectory + @"\launch.ini", comboBoxEdit2.Text + "launch.ini");
                    ListBoxLaunchFile.Items.Clear();
                    foreach (SectionData data in parser.ReadFile(AppDomain.CurrentDomain.BaseDirectory + @"\launch.ini").Sections)
                    {
                        ListBoxLaunchFile.Items.Add("------------------[" + data.SectionName + "]------------------");
                        foreach (KeyData data2 in data.Keys)
                        {
                            if ((data2.KeyName.ToLower() == "livestrong") && (data2.Value.ToLower() == "true"))
                            {
                                LiveStrong.Checked = true;
                                bool_0 = true;
                            }
                            if ((data2.KeyName.ToLower() == "liveblock") && (data2.Value.ToLower() == "true"))
                            {
                                LiveBlock.Checked = true;
                                bool_1 = true;
                            }
                            ListBoxLaunchFile.Items.Add(data2.KeyName + " = " + data2.Value);
                        }
                    }
                    Bool_3 = true;
                    if (!bool_2)
                    {
                        XtraMessageBox.Show("Sucessfully pulled launch.ini from " + comboBoxEdit2.Text);
                    }
                    bool_2 = false;
                }
                catch
                {
                    XtraMessageBox.Show("Failed to retrieve launch.ini from console. Please ensure your console is connected, and there is a Launch.ini on the selected drive.");
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < ListBoxLaunchFile.Items.Count; i++)
                {
                    if (ListBoxLaunchFile.Items[i].ToString().Contains("------------------"))
                    {
                        string item = ListBoxLaunchFile.Items[i].ToString().Replace("------------------", string.Empty);
                        ListBoxLaunchFile.Items.RemoveAt(i);
                        ListBoxLaunchFile.Items.Insert(i, item);
                    }
                }
                StreamWriter writer = new StreamWriter("launch.ini");
                foreach (object obj2 in ListBoxLaunchFile.Items)
                {
                    if (!obj2.ToString().ToLower().Contains("livestrong"))
                    {
                        if (obj2.ToString().ToLower().Contains("liveblock"))
                        {
                            if (bool_1)
                            {
                                writer.WriteLine("liveblock = true");
                            }
                            else
                            {
                                writer.WriteLine("liveblock = false");
                            }
                        }
                        else
                        {
                            writer.WriteLine(obj2);
                        }
                    }
                    else if (!bool_0)
                    {
                        writer.WriteLine("livestrong = false");
                    }
                    else
                    {
                        writer.WriteLine("livestrong = true");
                    }
                }
                writer.Close();
                XboxConsole.File.SendFile(AppDomain.CurrentDomain.BaseDirectory + @"\launch.ini", comboBoxEdit2.Text + "launch.ini");
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\launch.ini");
                XtraMessageBox.Show("Launch.ini re-wrote to console,\n  reboot for changes to take effect.");
                bool_2 = true;
                simpleButton1_Click(null, null);
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Failed to write launch.ini to console. Reboot, reconnect and try again.\n" + exception);
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            int index = ListBoxLaunchFile.Items.IndexOf("------------------[" + PathsCombo.Text + "]------------------") + 1;
            ListBoxLaunchFile.Items.Insert(index, Settings.Text + " = " + Value.Text);
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (LiveStrong.Checked)
            {
                LiveStrong.ForeColor = Color.Lime;
                bool_0 = true;
            }
            else
            {
                LiveStrong.ForeColor = Color.Red;
                bool_0 = false;
            }
            simpleButton2_Click(null, null);
            simpleButton1_Click(null, null);
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (LiveBlock.Checked)
            {
                LiveBlock.ForeColor = Color.Lime;
                bool_1 = true;
            }
            else
            {
                LiveBlock.ForeColor = Color.Red;
                bool_1 = false;
            }
            simpleButton2_Click(null, null);
            simpleButton1_Click(null, null);
        }

        private void ListUserClick(object sender, EventArgs e)
        {
            if (Bool_3)
            {
                INITextbox.Text = ListBoxLaunchFile.Items[ListBoxLaunchFile.SelectedIndex].ToString();

            }
        }

        private void INITextbox_TextChanged(object sender, EventArgs e)
        {
            ListBoxLaunchFile.Items[ListBoxLaunchFile.SelectedIndex] = INITextbox.Text;
        }
    }
}