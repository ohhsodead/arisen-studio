using System;
using System.IO;
using System.Net.Sockets;

namespace XDevkit
{
    public class FileSystem
    {

        #region XboxFile System
        /// <summary>
        /// Creates a directory on the xbox.
        /// </summary>
        /// <param name="name">Directory name.</param>
        public void CreateDirectory(string name)
        {
            string sdr = string.Concat("mkdir name=\"{0}\"", name);
            Xbox.SendTextCommand(sdr, out Xbox.Response);
        }
        /// <summary>
        /// Creates a directory on the xbox.
        /// </summary>
        /// <param name="name">Directory name.</param>
        public void GetDirectory(string name)
        {
            DownloadDirectory("", name);
        }

        /// <summary>
        /// Deletes a file on the xbox.
        /// </summary>
        /// <param name="fileName">File to delete.</param>
        public void DeleteFile(string fileName)
        {
            string dre = string.Concat("delete name=\"{0}\"", fileName);
            Xbox.SendTextCommand(dre);
        }

        /// <summary>
        /// Renames or moves a file on the xbox.
        /// </summary>
        /// <param name="oldFileName">Old file name.</param>
        /// <param name="newFileName">New file name.</param>
        public void RenameFile(string OldFileName, string NewFileName)
        {

            string ren = string.Concat("rename name=\"{0}\" newname=\"{1}\"", OldFileName, NewFileName);
            Xbox.SendTextCommand(ren);
        }
        public void UploadDirectory(string localFolder, string remoteFolderToSaveIn)
        {
            string str4;
            string[] files = Directory.GetFiles(localFolder);
            string[] directories = Directory.GetDirectories(localFolder);
            if (localFolder[localFolder.Length - 1] == '\\')
            {
                localFolder = localFolder.Substring(0, localFolder.Length - 1);
            }
            if (remoteFolderToSaveIn[remoteFolderToSaveIn.Length - 1] == '\\')
            {
                remoteFolderToSaveIn = remoteFolderToSaveIn.Substring(0, remoteFolderToSaveIn.Length - 1);
            }
            string[] strArray3 = localFolder.Split(new char[] { '\\' });
            string str = strArray3[strArray3.Length - 1];
            string directory = remoteFolderToSaveIn + @"\" + str + @"\";
            this.CreateDirectory(directory);
            foreach (string str3 in files)
            {
                strArray3 = str3.Split(new char[] { '\\' });
                str4 = strArray3[strArray3.Length - 1];
                this.UploadFile(str3, directory + str4);
            }
            foreach (string str5 in directories)
            {
                strArray3 = str5.Split(new char[] { '\\' });
                str4 = strArray3[strArray3.Length - 1];
                this.UploadDirectory(str5, directory);
            }
        }



        public void UploadFile(string localName, string remoteName)
        {
            SendFile(localName, remoteName);
        }
        /// <summary>
        /// Sends binary data of specified length to the xbox.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="length"></param>
        public void SendBinaryData(byte[] data, int length)
        {
            Xbox.XboxName.Client.Send(data, length, SocketFlags.None);
        }
        /// <summary>
        /// Receives all available binary data sent from the xbox.
        /// </summary>
        /// <returns></returns>
        public byte[] ReceiveBinaryData()
        {
            if (Xbox.XboxName.Available > 0)
            {
                byte[] binData = new byte[Xbox.XboxName.Available];
                Xbox.XboxName.Client.Receive(binData, binData.Length, SocketFlags.None);
                return binData;
            }
            else return null;
        }

        /// <summary>
        /// Receives binary data of specified size sent from the xbox.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public byte[] ReceiveBinaryData(int size)
        {
            Xbox.Wait(size);
            byte[] binData = new byte[size];
            Xbox.XboxName.Client.Receive(binData, binData.Length, SocketFlags.None);
            return binData;
        }
        /// <summary>
        /// Receives binary data of specified size sent from the xbox.
        /// </summary>
        /// <param name="data"></param>
        public void ReceiveBinaryData(byte[] data)
        {
            Xbox.Wait(data.Length);
            Xbox.XboxName.Client.Receive(data, data.Length, SocketFlags.None);
        }

        /// <summary>
        /// Receives binary data of specified size sent from the xbox.
        /// </summary>
        /// <param name="data"></param>
        public void ReceiveBinaryData(byte[] data, int offset, int size)
        {
            Xbox.Wait(size);
            Xbox.XboxName.Client.Receive(data, offset, size, SocketFlags.None);
        }
        /// <summary>
        /// Sends a file to the xbox.
        /// </summary>
        /// <param name="localName">PC file name.</param>
        /// <param name="remoteName">Xbox file name.</param>
        public void SendFile(string localName, string remoteName)
        {
            FileStream lfs = new FileStream(localName, FileMode.Open);
            byte[] fileData = new byte[Xbox.XboxName.Client.SendBufferSize];
            Xbox.SendTextCommand("sendfile name=\"{0}\" length={1}" + remoteName + lfs.Length);

            int mainIterations = (int)lfs.Length / Xbox.XboxName.Client.SendBufferSize;
            int remainder = (int)lfs.Length % Xbox.XboxName.Client.SendBufferSize;

            for (int i = 0; i < mainIterations; i++)
            {
                lfs.Read(fileData, 0, fileData.Length);
                SendBinaryData(fileData);
            }
            lfs.Read(fileData, 0, remainder);
            SendBinaryData(fileData, remainder);

            lfs.Close();
        }

        /// <summary>
        /// Sends binary data to the xbox.
        /// </summary>
        /// <param name="data"></param>
        public void SendBinaryData(byte[] data)
        {
            Xbox.XboxName.Client.Send(data);
        }

        public void DownloadFile(string localName, string remoteName)
        {
            ReceiveFile(localName, remoteName);
        }

        /// <summary>
        /// Receives a file from the xbox.
        /// </summary>
        /// <param name="localName">PC file name.</param>
        /// <param name="remoteName">Xbox file name.</param>
        public void ReceiveFile(string localName, string remoteName)
        {
            Xbox.SendTextCommand("getfile name=\"{0}\"" + remoteName);
            int fileSize = BitConverter.ToInt32(ReceiveBinaryData(4), 0);
            using (var lfs = new System.IO.FileStream(localName, FileMode.Create))
            {
                byte[] fileData = new byte[Xbox.XboxName.Client.ReceiveBufferSize];

                int mainIterations = fileSize / Xbox.XboxName.Client.ReceiveBufferSize;
                int remainder = fileSize % Xbox.XboxName.Client.ReceiveBufferSize;

                for (int i = 0; i < mainIterations; i++)
                {
                    fileData = ReceiveBinaryData(fileData.Length);
                    lfs.Write(fileData, 0, fileData.Length);
                }
                fileData = ReceiveBinaryData(remainder);
                lfs.Write(fileData, 0, remainder);
            }
        }

        public void DownloadDirectory(string localFolderToSaveIn, string remoteFolderPath)
        {
            string str4;
            string[] files = GetFiles(remoteFolderPath);
            string[] directories = GetDirectories(remoteFolderPath);
            if (remoteFolderPath[remoteFolderPath.Length - 1] == '\\')
            {
                remoteFolderPath = remoteFolderPath.Substring(0, remoteFolderPath.Length - 1);
            }
            if (localFolderToSaveIn[localFolderToSaveIn.Length - 1] == '\\')
            {
                localFolderToSaveIn = localFolderToSaveIn.Substring(0, localFolderToSaveIn.Length - 1);
            }
            string[] strArray3 = remoteFolderPath.Split(new char[] { '\\' });
            string str = strArray3[strArray3.Length - 1];
            string path = localFolderToSaveIn + @"\" + str + @"\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            foreach (string str3 in files)
            {
                strArray3 = str3.Split(new char[] { '\\' });
                str4 = strArray3[strArray3.Length - 1];
                this.DownloadFile(path + str4, str3);
            }
            foreach (string str5 in directories)
            {
                strArray3 = str5.Split(new char[] { '\\' });
                str4 = strArray3[strArray3.Length - 1];
                this.DownloadDirectory(path, str5);
            }
        }

        private string[] GetDirectories(string remoteFolderPath)//todo
        {
            throw new NotImplementedException();
        }

        private string[] GetFiles(string remoteFolderPath)//todo
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
