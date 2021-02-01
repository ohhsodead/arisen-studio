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
    public partial class AvatarItemDownloader : XtraForm
    {
        private static CultureInfo CI0 { get; set; }
        private static Func<int, bool> func_0;
        private static ResourceManager RM0;

        public AvatarItemDownloader()
        {
            InitializeComponent();
        }

        private void AvatarItemDownloader_Load(object sender, EventArgs e)
        {
        }

        private void TextBoxMarketplaceURL_EditValueChanged(object sender, EventArgs e)
        {
            TextBoxItemID.Text = TextBoxMarketplaceURL.Text.Substring(TextBoxMarketplaceURL.Text.Length - 0x24).ToUpper().Replace("-", string.Empty);
            TextBoxItemName.Text = Method_0().Remove(Method_0().Length - 0x25);
            var strArray = new string[] { "http://avatar.xboxlive.com/global/t.", TextBoxMarketplaceURL.Text.Substring(TextBoxMarketplaceURL.Text.Length - 8), "/avataritem/", TextBoxMarketplaceURL.Text.Substring(TextBoxMarketplaceURL.Text.Length - 0x24), "/300" };
            ImageAvatar.Load(string.Concat(strArray));
        }

        private void ButtonCheckURL_Click(object sender, EventArgs e)
        {
            if (TextBoxMarketplaceURL.Properties.MaxLength <= 80)
            {
                XtraMessageBox.Show("Please enter correct Marketplace URL like" + Environment.NewLine + "http://marketplace.xbox.com/en-US/Product/Lancer/00001000-95ce-e253-cea4-b7824d5308ab", "Check Marketplace URL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                TextBoxItemID.Text = TextBoxMarketplaceURL.Text.Substring(TextBoxMarketplaceURL.Text.Length - 0x24).ToUpper().Replace("-", string.Empty);
                TextBoxItemName.Text = Method_0().Remove(Method_0().Length - 0x25);
                var strArray = new string[] { "http://avatar.xboxlive.com/global/t.", TextBoxMarketplaceURL.Text.Substring(TextBoxMarketplaceURL.Text.Length - 8), "/avataritem/", TextBoxMarketplaceURL.Text.Substring(TextBoxMarketplaceURL.Text.Length - 0x24), "/300" };
                ImageAvatar.Load(string.Concat(strArray));
            }
        }

        private void ButtonDownloadItem_Click(object sender, EventArgs e)
        {
            ProgressBar.Visible = true;
            Directory.CreateDirectory(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37));
            File.Delete(".\\\\$AvatarItems\\\\" + Method_0().Remove(Method_0().Length - 37) + "\\" + TextBoxItemID.Text);
            File.Delete(".\\\\$AvatarItems\\\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate");
            File.WriteAllBytes(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", GetBytes());
            File.WriteAllText(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\ID.TXT", TextBoxMarketplaceURL.Text.Substring(TextBoxMarketplaceURL.Text.Length - 36).ToUpper().Replace("-", string.Empty));
            var webClient1 = new WebClient();
            var webClient2 = new WebClient();
            var webClient3 = new WebClient();
            webClient3.DownloadFileCompleted += new AsyncCompletedEventHandler(Method_8);
            webClient1.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Method_7);
            webClient1.DownloadFileAsync(new Uri("http://avatar.xboxlive.com/global/t." + TextBoxMarketplaceURL.Text.Substring(TextBoxMarketplaceURL.Text.Length - 8) + "/avataritem/" + TextBoxMarketplaceURL.Text.Substring(TextBoxMarketplaceURL.Text.Length - 36) + "/128"), ".\\\\$AvatarItems\\\\" + Method_0().Remove(Method_0().Length - 37) + "\\ICON.PNG");
            webClient2.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Method_7);
            webClient2.DownloadFileAsync(new Uri("http://avatar.xboxlive.com/global/t." + TextBoxMarketplaceURL.Text.Substring(TextBoxMarketplaceURL.Text.Length - 8) + "/avataritem/" + TextBoxMarketplaceURL.Text.Substring(TextBoxMarketplaceURL.Text.Length - 36) + "/64"), ".\\\\$AvatarItems\\\\" + Method_0().Remove(Method_0().Length - 37) + "\\ICON64.PNG");
            webClient3.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Method_7);
            webClient3.DownloadFileAsync(new Uri("http://download.xboxlive.com/content/" + TextBoxMarketplaceURL.Text.Substring(TextBoxMarketplaceURL.Text.Length - 8) + "/avataritems/v2/" + TextBoxMarketplaceURL.Text.Substring(TextBoxMarketplaceURL.Text.Length - 36) + ".bin"), ".\\\\$AvatarItems\\\\" + Method_0().Remove(Method_0().Length - 37) + "\\asset_v2.bin");
        }

        private void Method_1()
        {
            long num1 = 0;
            var num2 = 320;
            using var fileStream = File.Open(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\asset_v2.bin", FileMode.Open);
            var count = checked((int)(fileStream.Length - (num2 + num1)));
            var buffer = new byte[count];
            fileStream.Position = num1 + num2;
            fileStream.Read(buffer, 0, count);
            fileStream.Position = num1;
            fileStream.Write(buffer, 0, count);
            fileStream.SetLength(fileStream.Position);
        }

        private void Method_2()
        {
            while (true)
            {
                try
                {
                    File.ReadAllBytes(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate");
                    if (TextBoxXUID.Text.Length != 16)
                    {
                        var string_0 = "0009000000000000";
                        var fileStream = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
                        var binaryWriter = new BinaryWriter(fileStream);
                        fileStream.Position = Convert.ToInt64("23c", 16);
                        binaryWriter.Write(Smethod_1(string_0));
                        fileStream.Close();
                        break;
                    }
                    var fileStream1 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
                    var binaryWriter1 = new BinaryWriter(fileStream1);
                    fileStream1.Position = Convert.ToInt64("23c", 16);
                    binaryWriter1.Write(Smethod_1(TextBoxXUID.Text));
                    fileStream1.Close();
                    break;
                }
                catch
                {
                }
            }
        }

        private void Method_3()
        {
            while (true)
            {
                try
                {
                    File.ReadAllBytes(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate");
                    var hash = new SHA1CryptoServiceProvider().ComputeHash(File.ReadAllBytes(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate"), 836, 44220);
                    var fileStream = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
                    var binaryWriter = new BinaryWriter(fileStream);
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

        private void Method_4()
        {
            while (true)
            {
                try
                {
                    File.ReadAllBytes(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate");
                    File.Move(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", ".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\" + TextBoxItemID.Text);
                    break;
                }
                catch
                {
                }
            }
        }

        private void Method_5()
        {
            while (true)
            {
                try
                {
                    var buffer = File.ReadAllBytes(@".\$AvatarItems\" + Method_0().Remove(Method_0().Length - 0x25) + @"\icon64.png");
                    FileStream output = null;
                    BinaryWriter writer = null;
                    output = new FileStream(@".\$AvatarItems\" + Method_0().Remove(Method_0().Length - 0x25) + @"\AvatarItemTemplate", FileMode.OpenOrCreate);
                    writer = new BinaryWriter(output);
                    output.Position = Convert.ToInt64("171A", 0x10);
                    writer.Write(buffer);
                    output.Close();
                    output.Dispose();
                    writer.Close();
                    FileStream stream2 = null;
                    BinaryWriter writer2 = null;
                    stream2 = new FileStream(@".\$AvatarItems\" + Method_0().Remove(Method_0().Length - 0x25) + @"\AvatarItemTemplate", FileMode.OpenOrCreate);
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
                var package = new STFSPackage(@".\$AvatarItems\" + Method_0().Remove(Method_0().Length - 0x25) + @"\AvatarItemTemplate", null);
                package.GetFile("asset_v2.bin").Replace(@".\$AvatarItems\" + Method_0().Remove(Method_0().Length - 0x25) + @"\asset_v2.bin");
                package.GetFile("icon.png").Replace(@".\$AvatarItems\" + Method_0().Remove(Method_0().Length - 0x25) + @"\icon.png");
                package.RebuildPackage(new RSAParams(StrongSigned.LIVE));
                package.FlushPackage(new RSAParams(StrongSigned.LIVE));
                package.CloseIO();
                return;
            }
        }

        private void Method_6()
        {
            var fileStream1 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter1 = new BinaryWriter(fileStream1);
            fileStream1.Position = Convert.ToInt64("3E1", 16);
            binaryWriter1.Write(Smethod_1(TextBoxItemID.Text + "03"));
            fileStream1.Close();
            var fileStream2 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter2 = new BinaryWriter(fileStream2);
            fileStream2.Position = Convert.ToInt64("412", 16);
            binaryWriter2.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
            fileStream2.Close();
            var fileStream3 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter3 = new BinaryWriter(fileStream3);
            fileStream3.Position = Convert.ToInt64("512", 16);
            binaryWriter3.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
            fileStream3.Close();
            var fileStream4 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter4 = new BinaryWriter(fileStream4);
            fileStream4.Position = Convert.ToInt64("612", 16);
            binaryWriter4.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
            fileStream4.Close();
            var fileStream5 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter5 = new BinaryWriter(fileStream5);
            fileStream5.Position = Convert.ToInt64("712", 16);
            binaryWriter5.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
            fileStream5.Close();
            var fileStream6 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter6 = new BinaryWriter(fileStream6);
            fileStream6.Position = Convert.ToInt64("812", 16);
            binaryWriter6.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
            fileStream6.Close();
            var fileStream7 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter7 = new BinaryWriter(fileStream7);
            fileStream7.Position = Convert.ToInt64("912", 16);
            binaryWriter7.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
            fileStream7.Close();
            var fileStream8 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter8 = new BinaryWriter(fileStream8);
            fileStream8.Position = Convert.ToInt64("A12", 16);
            binaryWriter8.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
            fileStream8.Close();
            var fileStream9 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter9 = new BinaryWriter(fileStream9);
            fileStream9.Position = Convert.ToInt64("B12", 16);
            binaryWriter9.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
            fileStream9.Close();
            var fileStream10 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter10 = new BinaryWriter(fileStream10);
            fileStream10.Position = Convert.ToInt64("C12", 16);
            binaryWriter10.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
            fileStream10.Close();
            var fileStream11 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter11 = new BinaryWriter(fileStream11);
            fileStream11.Position = Convert.ToInt64("D12", 16);
            binaryWriter11.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
            fileStream11.Close();
            var fileStream12 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter12 = new BinaryWriter(fileStream12);
            fileStream12.Position = Convert.ToInt64("E12", 16);
            binaryWriter12.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
            fileStream12.Close();
            var fileStream13 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter13 = new BinaryWriter(fileStream13);
            fileStream13.Position = Convert.ToInt64("F12", 16);
            binaryWriter13.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
            fileStream13.Close();
            var fileStream14 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter14 = new BinaryWriter(fileStream14);
            fileStream14.Position = Convert.ToInt64("1012", 16);
            binaryWriter14.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
            fileStream14.Close();
            var fileStream15 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter15 = new BinaryWriter(fileStream15);
            fileStream15.Position = Convert.ToInt64("1112", 16);
            binaryWriter15.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
            fileStream15.Close();
            var fileStream16 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter16 = new BinaryWriter(fileStream16);
            fileStream16.Position = Convert.ToInt64("1212", 16);
            binaryWriter16.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
            fileStream16.Close();
            var fileStream17 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter17 = new BinaryWriter(fileStream17);
            fileStream17.Position = Convert.ToInt64("1312", 16);
            binaryWriter17.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
            fileStream17.Close();
            var fileStream18 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter18 = new BinaryWriter(fileStream18);
            fileStream18.Position = Convert.ToInt64("1412", 16);
            binaryWriter18.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
            fileStream18.Close();
            var fileStream19 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter19 = new BinaryWriter(fileStream19);
            fileStream19.Position = Convert.ToInt64("1512", 16);
            binaryWriter19.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
            fileStream19.Close();
            var fileStream20 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter20 = new BinaryWriter(fileStream20);
            fileStream20.Position = Convert.ToInt64("1612", 16);
            binaryWriter20.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
            fileStream20.Close();
            if (TextBoxGameTitle.Text.Length == 0)
            {
                var fileStream21 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
                var binaryWriter21 = new BinaryWriter(fileStream21);
                fileStream21.Position = Convert.ToInt64("1692", 16);
                binaryWriter21.Write(Smethod_1(Smethod_0(TextBoxItemName.Text)));
                fileStream21.Close();
            }
            var fileStream22 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter22 = new BinaryWriter(fileStream22);
            fileStream22.Position = Convert.ToInt64("1692", 16);
            binaryWriter22.Write(Smethod_1(Smethod_0(TextBoxGameTitle.Text)));
            fileStream22.Close();
            var fileStream23 = new FileStream(".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 37) + "\\AvatarItemTemplate", FileMode.OpenOrCreate);
            var binaryWriter23 = new BinaryWriter(fileStream23);
            fileStream23.Position = Convert.ToInt64("360", 16);
            binaryWriter23.Write(Smethod_1(TextBoxItemID.Text.Substring(24)));
            fileStream23.Close();
        }

        private void Method_7(object sender, DownloadProgressChangedEventArgs e)
        {
            ProgressBar.EditValue = e.ProgressPercentage;
        }

        private void Method_8(object sender, AsyncCompletedEventArgs e)
        {
            Method_1();
            Method_5();
            Method_6();
            ProgressBar.Visible = false;
            XtraMessageBox.Show(Environment.NewLine + "check $AvatarItems folder" + Environment.NewLine, "Download complete");
            //TODO:ADD a tranfer to xbox system and xuid reader
            File.Delete(@".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 0x25) + @"\asset_v2.bin");
            File.Delete(@".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 0x25) + @"\icon.png");
            File.Delete(@".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 0x25) + @"\icon64.png");
            File.Delete(@".\\$AvatarItems\\" + Method_0().Remove(Method_0().Length - 0x25) + @"\ID.txt");
            Method_2();
            Method_3();
            Method_4();
        }

        private static bool Smethod_2(int int_0) => ((int_0 % 2) == 0);

        internal static ResourceManager CIA()
        {
            if (RM0 is null)
            {
                RM0 = new ResourceManager("AvatarTools.Form1", typeof(AvatarItemDownloader).Assembly);
            }

            return RM0;
        }

        internal static byte[] GetBytes() => ((byte[])CIA().GetObject("AvatarItemTemplate", CI0));

        public string Method_0() => TextBoxMarketplaceURL.Text.Substring(0x2a).Replace('-', ' ');

        public static string Smethod_0(string string_0)
        {
            var builder = new StringBuilder();

            foreach (var ch in string_0)
            {
                builder.Append(Convert.ToInt32(ch).ToString("x") + "00");
            }

            return builder.ToString();
        }

        public static byte[] Smethod_1(string string_0)
        {
            var class2 = new Class2
            {
                string_0 = string_0
            };

            if (func_0 == null)
            {
                func_0 = new Func<int, bool>(Smethod_2);
            }

            return Enumerable.ToArray(Enumerable.Select(Enumerable.Where(Enumerable.Range(0, class2.string_0.Length), func_0), new Func<int, byte>(class2.Method_0)));
        }

        private sealed class Class2
        {
            public string string_0;

            public byte Method_0(int int_0) => Convert.ToByte(string_0.Substring(int_0, 2), 0x10);
        }
    }
}