using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using X360.STFS;

namespace ModioX.Forms.Tools.XBOX_Tools
{
    public partial class Form1 : XtraForm
    {
        private static CultureInfo CI0;
        private static Func<int, bool> func_0;
        private static ResourceManager RM0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.MPURLBox.TextLength <= 80)
            {
                MessageBox.Show("Please enter correct Marketplace URL like" + Environment.NewLine + "http://marketplace.xbox.com/en-US/Product/Lancer/00001000-95ce-e253-cea4-b7824d5308ab", "Check Marketplace URL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                this.ItemIDBox.Text = this.MPURLBox.Text.Substring(this.MPURLBox.Text.Length - 0x24).ToUpper().Replace("-", string.Empty);
                this.ItemNameBox.Text = this.method_0().Remove(this.method_0().Length - 0x25);
                string[] strArray = new string[] { "http://avatar.xboxlive.com/global/t.", this.MPURLBox.Text.Substring(this.MPURLBox.Text.Length - 8), "/avataritem/", this.MPURLBox.Text.Substring(this.MPURLBox.Text.Length - 0x24), "/300" };
                this.pictureBox1.ImageLocation = string.Concat(strArray);
            }
            if (this.MPURLBox.TextLength <= 80)
            {
                MessageBox.Show("Please enter correct Marketplace URL like" + Environment.NewLine + "http://marketplace.xbox.com/en-US/Product/Lancer/00001000-95ce-e253-cea4-b7824d5308ab", "Check Marketplace URL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                this.ItemIDBox.Text = this.MPURLBox.Text.Substring(this.MPURLBox.Text.Length - 0x24).ToUpper().Replace("-", string.Empty);
                this.ItemNameBox.Text = this.method_0().Remove(this.method_0().Length - 0x25);
                string[] strArray = new string[] { "http://avatar.xboxlive.com/global/t.", this.MPURLBox.Text.Substring(this.MPURLBox.Text.Length - 8), "/avataritem/", this.MPURLBox.Text.Substring(this.MPURLBox.Text.Length - 0x24), "/300" };
                this.pictureBox1.ImageLocation = string.Concat(strArray);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void DL_BTN_Click(object sender, EventArgs e)
        {
            this.progressBar.Visible = true;
            Directory.CreateDirectory(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37));
            System.IO.File.Delete(".\\\\$AvatarItems\\\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\" + this.ItemIDBox.Text);
            System.IO.File.Delete(".\\\\$AvatarItems\\\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate");
            // ISSUE: reference to a compiler-generated method
            System.IO.File.WriteAllBytes(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", GetBytes());
            System.IO.File.WriteAllText(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\ID.TXT", this.MPURLBox.Text.Substring(this.MPURLBox.Text.Length - 36).ToUpper().Replace("-", string.Empty));
            WebClient webClient1 = new WebClient();
            WebClient webClient2 = new WebClient();
            WebClient webClient3 = new WebClient();
            webClient3.DownloadFileCompleted += new AsyncCompletedEventHandler(this.method_8);
            webClient1.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.method_7);
            webClient1.DownloadFileAsync(new Uri("http://avatar.xboxlive.com/global/t." + this.MPURLBox.Text.Substring(this.MPURLBox.Text.Length - 8) + "/avataritem/" + this.MPURLBox.Text.Substring(this.MPURLBox.Text.Length - 36) + "/128"), ".\\\\$AvatarItems\\\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\ICON.PNG");
            webClient2.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.method_7);
            webClient2.DownloadFileAsync(new Uri("http://avatar.xboxlive.com/global/t." + this.MPURLBox.Text.Substring(this.MPURLBox.Text.Length - 8) + "/avataritem/" + this.MPURLBox.Text.Substring(this.MPURLBox.Text.Length - 36) + "/64"), ".\\\\$AvatarItems\\\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\ICON64.PNG");
            webClient3.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.method_7);
            webClient3.DownloadFileAsync(new Uri("http://download.xboxlive.com/content/" + this.MPURLBox.Text.Substring(this.MPURLBox.Text.Length - 8) + "/avataritems/v2/" + this.MPURLBox.Text.Substring(this.MPURLBox.Text.Length - 36) + ".bin"), ".\\\\$AvatarItems\\\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\asset_v2.bin");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MPURLBox.TextChanged += new EventHandler(this.MPURLBox_TextChanged);
        }

        private void method_1()
        {
            long num1 = 0;
            int num2 = 320;
            using (FileStream fileStream = System.IO.File.Open(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\asset_v2.bin", FileMode.Open))
            {
                int count = checked((int)(fileStream.Length - ((long)num2 + num1)));
                byte[] buffer = new byte[count];
                fileStream.Position = num1 + (long)num2;
                fileStream.Read(buffer, 0, count);
                fileStream.Position = num1;
                fileStream.Write(buffer, 0, count);
                fileStream.SetLength(fileStream.Position);
            }
        }

        private void method_2()
        {
            while (true)
            {
                try
                {
                    System.IO.File.ReadAllBytes(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate");
                    if (this.XUIDBox.Text.Length != 16)
                    {
                        string string_0 = "0009000000000000";
                        FileStream fileStream = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
                        BinaryWriter binaryWriter = new BinaryWriter((Stream)fileStream);
                        fileStream.Position = Convert.ToInt64("23c", 16);
                        binaryWriter.Write(Form1.smethod_1(string_0));
                        fileStream.Close();
                        break;
                    }
                    FileStream fileStream1 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
                    BinaryWriter binaryWriter1 = new BinaryWriter((Stream)fileStream1);
                    fileStream1.Position = Convert.ToInt64("23c", 16);
                    binaryWriter1.Write(Form1.smethod_1(this.XUIDBox.Text));
                    fileStream1.Close();
                    break;
                }
                catch
                {
                }
            }
        }

        private void method_3()
        {
            while (true)
            {
                try
                {
                    System.IO.File.ReadAllBytes(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate");
                    byte[] hash = new SHA1CryptoServiceProvider().ComputeHash(System.IO.File.ReadAllBytes(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate"), 836, 44220);
                    FileStream fileStream = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)fileStream);
                    fileStream.Position = Convert.ToInt64("32C", 16);
                    binaryWriter.Write(hash);
                    fileStream.Close();
                    break;
                }
                catch
                {
                }
            }
        }

        private void method_4()
        {
            while (true)
            {
                try
                {
                    System.IO.File.ReadAllBytes(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate");
                    System.IO.File.Move(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", ".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\" + this.ItemIDBox.Text);
                    break;
                }
                catch
                {
                }
            }
        }

        private void method_5()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = System.IO.File.ReadAllBytes(@".\$AvatarItems\" + this.method_0().Remove(this.method_0().Length - 0x25) + @"\icon64.png");
                    FileStream output = null;
                    BinaryWriter writer = null;
                    output = new FileStream(@".\$AvatarItems\" + this.method_0().Remove(this.method_0().Length - 0x25) + @"\AvatarItemTemplate", FileMode.OpenOrCreate);
                    writer = new BinaryWriter(output);
                    output.Position = Convert.ToInt64("171A", 0x10);
                    writer.Write(buffer);
                    output.Close();
                    output.Dispose();
                    writer.Close();
                    FileStream stream2 = null;
                    BinaryWriter writer2 = null;
                    stream2 = new FileStream(@".\$AvatarItems\" + this.method_0().Remove(this.method_0().Length - 0x25) + @"\AvatarItemTemplate", FileMode.OpenOrCreate);
                    writer2 = new BinaryWriter(stream2);
                    stream2.Position = Convert.ToInt64("571A", 0x10);
                    writer2.Write(buffer);
                    stream2.Close();
                    stream2.Dispose();
                    writer2.Close();
                }
                catch (IOException)
                {
                    continue;
                }
                STFSPackage package = new STFSPackage(@".\$AvatarItems\" + this.method_0().Remove(this.method_0().Length - 0x25) + @"\AvatarItemTemplate", null);
                package.GetFile("asset_v2.bin").Replace(@".\$AvatarItems\" + this.method_0().Remove(this.method_0().Length - 0x25) + @"\asset_v2.bin");
                package.GetFile("icon.png").Replace(@".\$AvatarItems\" + this.method_0().Remove(this.method_0().Length - 0x25) + @"\icon.png");
                package.RebuildPackage(new RSAParams(StrongSigned.LIVE));
                package.FlushPackage(new RSAParams(StrongSigned.LIVE));
                package.CloseIO();
                return;
            }
        }

        private void method_6()
        {
            FileStream fileStream1 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter1 = new BinaryWriter((Stream)fileStream1);
            fileStream1.Position = Convert.ToInt64("3E1", 16);
            binaryWriter1.Write(Form1.smethod_1(this.ItemIDBox.Text + "03"));
            fileStream1.Close();
            FileStream fileStream2 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter2 = new BinaryWriter((Stream)fileStream2);
            fileStream2.Position = Convert.ToInt64("412", 16);
            binaryWriter2.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
            fileStream2.Close();
            FileStream fileStream3 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter3 = new BinaryWriter((Stream)fileStream3);
            fileStream3.Position = Convert.ToInt64("512", 16);
            binaryWriter3.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
            fileStream3.Close();
            FileStream fileStream4 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter4 = new BinaryWriter((Stream)fileStream4);
            fileStream4.Position = Convert.ToInt64("612", 16);
            binaryWriter4.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
            fileStream4.Close();
            FileStream fileStream5 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter5 = new BinaryWriter((Stream)fileStream5);
            fileStream5.Position = Convert.ToInt64("712", 16);
            binaryWriter5.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
            fileStream5.Close();
            FileStream fileStream6 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter6 = new BinaryWriter((Stream)fileStream6);
            fileStream6.Position = Convert.ToInt64("812", 16);
            binaryWriter6.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
            fileStream6.Close();
            FileStream fileStream7 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter7 = new BinaryWriter((Stream)fileStream7);
            fileStream7.Position = Convert.ToInt64("912", 16);
            binaryWriter7.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
            fileStream7.Close();
            FileStream fileStream8 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter8 = new BinaryWriter((Stream)fileStream8);
            fileStream8.Position = Convert.ToInt64("A12", 16);
            binaryWriter8.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
            fileStream8.Close();
            FileStream fileStream9 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter9 = new BinaryWriter((Stream)fileStream9);
            fileStream9.Position = Convert.ToInt64("B12", 16);
            binaryWriter9.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
            fileStream9.Close();
            FileStream fileStream10 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter10 = new BinaryWriter((Stream)fileStream10);
            fileStream10.Position = Convert.ToInt64("C12", 16);
            binaryWriter10.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
            fileStream10.Close();
            FileStream fileStream11 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter11 = new BinaryWriter((Stream)fileStream11);
            fileStream11.Position = Convert.ToInt64("D12", 16);
            binaryWriter11.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
            fileStream11.Close();
            FileStream fileStream12 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter12 = new BinaryWriter((Stream)fileStream12);
            fileStream12.Position = Convert.ToInt64("E12", 16);
            binaryWriter12.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
            fileStream12.Close();
            FileStream fileStream13 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter13 = new BinaryWriter((Stream)fileStream13);
            fileStream13.Position = Convert.ToInt64("F12", 16);
            binaryWriter13.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
            fileStream13.Close();
            FileStream fileStream14 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter14 = new BinaryWriter((Stream)fileStream14);
            fileStream14.Position = Convert.ToInt64("1012", 16);
            binaryWriter14.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
            fileStream14.Close();
            FileStream fileStream15 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter15 = new BinaryWriter((Stream)fileStream15);
            fileStream15.Position = Convert.ToInt64("1112", 16);
            binaryWriter15.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
            fileStream15.Close();
            FileStream fileStream16 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter16 = new BinaryWriter((Stream)fileStream16);
            fileStream16.Position = Convert.ToInt64("1212", 16);
            binaryWriter16.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
            fileStream16.Close();
            FileStream fileStream17 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter17 = new BinaryWriter((Stream)fileStream17);
            fileStream17.Position = Convert.ToInt64("1312", 16);
            binaryWriter17.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
            fileStream17.Close();
            FileStream fileStream18 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter18 = new BinaryWriter((Stream)fileStream18);
            fileStream18.Position = Convert.ToInt64("1412", 16);
            binaryWriter18.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
            fileStream18.Close();
            FileStream fileStream19 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter19 = new BinaryWriter((Stream)fileStream19);
            fileStream19.Position = Convert.ToInt64("1512", 16);
            binaryWriter19.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
            fileStream19.Close();
            FileStream fileStream20 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter20 = new BinaryWriter((Stream)fileStream20);
            fileStream20.Position = Convert.ToInt64("1612", 16);
            binaryWriter20.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
            fileStream20.Close();
            if (this.GameNameBox.Text.Length == 0)
            {
                FileStream fileStream21 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
                BinaryWriter binaryWriter21 = new BinaryWriter((Stream)fileStream21);
                fileStream21.Position = Convert.ToInt64("1692", 16);
                binaryWriter21.Write(Form1.smethod_1(Form1.smethod_0(this.ItemNameBox.Text)));
                fileStream21.Close();
            }
            FileStream fileStream22 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter22 = new BinaryWriter((Stream)fileStream22);
            fileStream22.Position = Convert.ToInt64("1692", 16);
            binaryWriter22.Write(Form1.smethod_1(Form1.smethod_0(this.GameNameBox.Text)));
            fileStream22.Close();
            FileStream fileStream23 = new FileStream(".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter23 = new BinaryWriter((Stream)fileStream23);
            fileStream23.Position = Convert.ToInt64("360", 16);
            binaryWriter23.Write(Form1.smethod_1(this.ItemIDBox.Text.Substring(24)));
            fileStream23.Close();
        }
        private void method_7(object sender, DownloadProgressChangedEventArgs e)
        {
            this.progressBar.Value = e.ProgressPercentage;
        }

        private void method_8(object sender, AsyncCompletedEventArgs e)
        {
            this.method_1();
            this.method_5();
            this.method_6();
            this.progressBar.Visible = false;
            MessageBox.Show(Environment.NewLine + "check $AvatarItems folder" + Environment.NewLine, "Download complete");
            //work here TODO:ADD a tranfer to xbox system and xuid reader
            System.IO.File.Delete(@".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 0x25) + @"\asset_v2.bin");
            System.IO.File.Delete(@".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 0x25) + @"\icon.png");
            System.IO.File.Delete(@".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 0x25) + @"\icon64.png");
            System.IO.File.Delete(@".\\$AvatarItems\\" + this.method_0().Remove(this.method_0().Length - 0x25) + @"\ID.txt");
            this.method_2();
            this.method_3();
            this.method_4();
        }

        private void MPURLBox_TextChanged(object sender, EventArgs e)
        {
            this.ItemIDBox.Text = this.MPURLBox.Text.Substring(this.MPURLBox.Text.Length - 0x24).ToUpper().Replace("-", string.Empty);
            this.ItemNameBox.Text = this.method_0().Remove(this.method_0().Length - 0x25);
            string[] strArray = new string[] { "http://avatar.xboxlive.com/global/t.", this.MPURLBox.Text.Substring(this.MPURLBox.Text.Length - 8), "/avataritem/", this.MPURLBox.Text.Substring(this.MPURLBox.Text.Length - 0x24), "/300" };
            this.pictureBox1.ImageLocation = string.Concat(strArray);
        }
        private static bool smethod_2(int int_0) =>
    ((int_0 % 2) == 0);

        internal static ResourceManager CIA()
        {
            if (ReferenceEquals(RM0, null))
            {
                RM0 = new ResourceManager("AvatarTools.Form1", typeof(Form1).Assembly);
            }
            return RM0;
        }
        internal static byte[] GetBytes() =>
            ((byte[])CIA().GetObject("AvatarItemTemplate", CI0));

        public string method_0() => this.MPURLBox.Text.Substring(0x2a).Replace('-', ' ');
        public static string smethod_0(string string_0)
        {
            StringBuilder builder = new StringBuilder();
            foreach (char ch in string_0)
            {
                builder.Append(Convert.ToInt32(ch).ToString("x") + "00");
            }
            return builder.ToString();
        }
        public static byte[] smethod_1(string string_0)
        {
            Class2 class2 = new Class2
            {
                string_0 = string_0
            };
            if (func_0 == null)
            {
                func_0 = new Func<int, bool>(Form1.smethod_2);
            }
            return Enumerable.ToArray<byte>(Enumerable.Select<int, byte>(Enumerable.Where<int>(Enumerable.Range(0, class2.string_0.Length), func_0), new Func<int, byte>(class2.method_0)));
        }

        private sealed class Class2
        {
            public string string_0;

            public byte method_0(int int_0) =>
                Convert.ToByte(this.string_0.Substring(int_0, 2), 0x10);
        }
    }
}
