using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModioX;
using XDevkit;
using IniParser;
using IniParser.Model;
using ModioX.Forms.Windows;
using System.IO;

namespace ModioX.Forms.Tools.XBOX_Tools
{
    public partial class iniEditor : XtraForm
    {
        /// <summary>
        /// Creates an FTP connection for use with uploading mods, not reliable for uploading files.
        /// </summary>
        public static Xbox XboxConsole { get; } = MainWindow.XboxConsole;

        private bool bool_0 { get; set; } = false;
        private bool bool_1 { get; set; } = false;
        private bool bool_2 { get; set; } = false;
        private bool Bool_3 { get; set; } = false;

        public iniEditor()
        {
            InitializeComponent();
        }

        private void iniEditor_Load(object sender, EventArgs e)
        {
            comboBoxEdit2.Properties.Items.Clear();

            foreach (string str in XboxConsole.FileSystem.Drives.Split(','))
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
                    XboxConsole.FileSystem.ReceiveFile(AppDomain.CurrentDomain.BaseDirectory + @"\launch.ini", comboBoxEdit2.Text + "launch.ini");
                    List.Items.Clear();
                    foreach (SectionData data in parser.ReadFile(AppDomain.CurrentDomain.BaseDirectory + @"\launch.ini").Sections)
                    {
                        List.Items.Add("------------------[" + data.SectionName + "]------------------");
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
                            List.Items.Add(data2.KeyName + " = " + data2.Value);
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
                for (int i = 0; i < List.Items.Count; i++)
                {
                    if (List.Items[i].ToString().Contains("------------------"))
                    {
                        string item = List.Items[i].ToString().Replace("------------------", string.Empty);
                        List.Items.RemoveAt(i);
                        List.Items.Insert(i, item);
                    }
                }
                StreamWriter writer = new StreamWriter("launch.ini");
                foreach (object obj2 in List.Items)
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
                XboxConsole.SendFile(AppDomain.CurrentDomain.BaseDirectory + @"\launch.ini", comboBoxEdit2.Text + "launch.ini");
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
            int index = List.Items.IndexOf("------------------[" + PathsCombo.Text + "]------------------") + 1;
            List.Items.Insert(index, Settings.Text + " = " + Value.Text);
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
            if(Bool_3)
            {
                INITextbox.Text = List.Items[List.SelectedIndex].ToString();

            }
        }

        private void INITextbox_TextChanged(object sender, EventArgs e)
        {
            List.Items[List.SelectedIndex] = INITextbox.Text;
        }
    }
}