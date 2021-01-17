using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace XDevkit
{
    public class XMessageBoxUI
    {
        public volatile bool IsMessageBoxOpen = false;
        public int SelectedButton = 0;
        public Xbox Console = new Xbox();
        public ActiveXMessageBoxes CurMessageBox;
        public volatile uint XOverlappedAddr;
        public volatile uint ResultAddr;
        public string MessageBoxTitle;
        public string MessageBoxMessage;
        public string[] XMessageBoxButtons;
        public XMessageBoxIcons XMessageBoxIcon;

        //public event EventHandler<XMessageBoxUIProgress> MessageBoxUIResult;

        public XMessageBoxUI(

          string MsgBoxTitle,
          string MsgBoxMsg,
          string[] MsgBoxButtons,
          XMessageBoxIcons Icon,
          int SelectedButtonIndex)
        {
            Console = new Xbox();
            MessageBoxTitle = MsgBoxTitle;
            MessageBoxMessage = MsgBoxMsg;
            XMessageBoxButtons = MsgBoxButtons;
            XMessageBoxIcon = Icon;
            SelectedButton = SelectedButtonIndex;
        }

        public void RemoveMessageBox(ActiveXMessageBoxes mBox)
        {
            XMessageBoxTracking.ActiveMessageBoxes.Remove(CurMessageBox);
            if (XMessageBoxTracking.ActiveMessageBoxes.Count() <= 0)
                return;
            Console.SetMemory(XOverlappedAddr, XMessageBoxTracking.ActiveMessageBoxes.Last().XOverlappedBytes);
        }

        public void CheckMessageBoxResult()
        {
            while (IsMessageBoxOpen)
            {
                try
                {
                    if (CurMessageBox == XMessageBoxTracking.ActiveMessageBoxes.Last())
                    {
                        uint code = Console.GetUInt32(XOverlappedAddr);
                        uint result = 0;
                        switch (code)
                        {
                            case 0:
                                result = Console.GetUInt32(ResultAddr);
                                IsMessageBoxOpen = false;
                                goto case 997;
                            case 997:
                                if (!IsMessageBoxOpen)
                                {
                                    RemoveMessageBox(CurMessageBox);
                                    //  MessageBoxUIResult((object)new XMessageBoxUIProgress(result, code));
                                }
                                break;
                            case 1223:
                            case 1627:
                                result = 420U;
                                IsMessageBoxOpen = false;
                                goto case 997;
                            default:
                                result = 710U;
                                IsMessageBoxOpen = false;
                                goto case 997;
                        }
                    }
                    Thread.Sleep(200);
                }
                catch (Exception)
                {
                    break;
                }
            }
        }

        public bool Show()
        {
            if (IsMessageBoxOpen)
            {
                int num = (int)MessageBox.Show("XMessageBox is already open. Close it before opening it again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            if (((IEnumerable<string>)XMessageBoxButtons).Count<string>() > 3)
            {
                int num = (int)MessageBox.Show("Number of buttons may not exceed 3.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            if (((IEnumerable<string>)XMessageBoxButtons).Count<string>() == 0)
            {
                int num = (int)MessageBox.Show("Must have at least one button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            uint num1 = Console.ResolveFunction("xam.xex", 2601U) + 12288U;
            uint num2 = num1;
            uint num3 = num1 + 32U;
            foreach (ActiveXMessageBoxes activeMessageBox in XMessageBoxTracking.ActiveMessageBoxes)
                num1 += activeMessageBox.Size;
            byte[] Data1 = Functions.WCHAR(MessageBoxTitle);
            uint Address1 = num3 + 16U;
            Console.SetMemory(Address1, Data1);
            byte[] Data2 = Functions.WCHAR(MessageBoxMessage);
            uint Address2 = Address1 + (uint)Data1.Length;
            Console.SetMemory(Address2, Data2);
            List<byte[]> source = new List<byte[]>();
            foreach (string xmessageBoxButton in XMessageBoxButtons)
                source.Add(xmessageBoxButton.ToWCHAR());
            uint Address3 = Address2 + (uint)Data2.Length;
            uint num4 = Address3;
            foreach (byte[] Data3 in source)
            {
                Console.SetMemory(Address3, Data3);
                Address3 += (uint)Data3.Length;
            }
            uint Address4 = num1;
            for (int index = 0; index < source.Count<byte[]>(); ++index)
            {
                Address4 = Address3 + (uint)(index * 4);
                Console.SetUInt32(Address4, num4);
                num4 += (uint)source.ElementAt<byte[]>(index).Length;
            }
            if (Console.Call<int>("xam.xex", 714, 0U, Address1, Address2, source.Count(), Address3, SelectedButton, (uint)XMessageBoxIcon, num3, num2) == 997)
            {
                IsMessageBoxOpen = true;
                XOverlappedAddr = num2;
                ResultAddr = XOverlappedAddr + 32U;
                byte[] memory = Console.GetMemory(XOverlappedAddr, 32U);
                uint size = Address4 + 4U - num1;
                while (((int)size & 3) != 0)
                    ++size;
                CurMessageBox = new ActiveXMessageBoxes(size, memory);
                XMessageBoxTracking.ActiveMessageBoxes.Add(CurMessageBox);
                new Thread(new ThreadStart(CheckMessageBoxResult)).Start();
            }
            else
                IsMessageBoxOpen = false;
            return IsMessageBoxOpen;
        }
    }
    public class XMessageBoxUIProgress : EventArgs
    {
        private XMessageBoxUIProgress()
        {
        }

        public XMessageBoxUIProgress(uint result, uint code)
        {
            Result = result;
            Code = code;
        }

        public uint Result { get; private set; }

        public uint Code { get; private set; }
    }
    public static class XMessageBoxTracking
    {
        public static List<ActiveXMessageBoxes> ActiveMessageBoxes = new List<ActiveXMessageBoxes>();
    }
    public class ActiveXMessageBoxes
    {
        public uint Size;
        public byte[] XOverlappedBytes;

        public ActiveXMessageBoxes(uint size, byte[] xOverlappedBytes)
        {
            Size = size;
            XOverlappedBytes = xOverlappedBytes;
        }
    }
}
