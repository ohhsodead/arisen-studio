using System;
using System.Text;

namespace XDevkit
{
    /// <summary>
    /// Made By TeddyHammer If Copied You Must Give Credit... Do Not Delete This Comment..
    /// </summary>
    public class XNotify 
    {

        public static void XMessage(int int_4, string string_11, string string_12, int int_5, string[] string_13, int int_6, int int_7)
        {
            Xbox Xconsole = new Xbox();
            try
            {
                uint address = Xconsole.ResolveFunction("xam.xex", 0x2ca);
                uint num2 = 0x81b01480;
                byte[] data = new byte[6];
                byte[] buffer2 = new byte[0x1c];
                byte[] buffer3 = new byte[0];
                byte[] buffer4 = new byte[0];
                byte[] buffer5 = new byte[0];
                uint num3 = 0;
                uint num4 = 0;
                uint num5 = 0;
                uint num6 = 0;
                Xconsole.SetMemory(0x81b01480, data);
                Xconsole.SetMemory(0x81b01486, buffer2);
                uint num7 = 0x22;
                byte[] buffer6 = string_11.ToWCHAR();
                byte[] buffer7 = string_12.ToWCHAR();
                if (int_5 >= 1)
                {
                    buffer3 = string_13[0].ToWCHAR();
                }
                if (int_5 >= 2)
                {
                    buffer4 = string_13[1].ToWCHAR();
                }
                if (int_5 == 3)
                {
                    buffer5 = string_13[2].ToWCHAR();
                }
                Xconsole.SetMemory(num2 + num7, buffer6);
                uint num8 = num2 + num7;
                num7 += (uint)buffer6.Length;
                Xconsole.SetMemory(num2 + num7, buffer7);
                uint num9 = num2 + num7;
                num7 += (uint)buffer7.Length;
                if (int_5 >= 1)
                {
                    Xconsole.SetMemory(num2 + num7, buffer3);
                    num3 = num2 + num7;
                    num7 += (uint)buffer3.Length;
                }
                if (int_5 >= 2)
                {
                    Xconsole.SetMemory(num2 + num7, buffer4);
                    num4 = num2 + num7;
                    num7 += (uint)buffer4.Length;
                }
                if (int_5 == 3)
                {
                    Xconsole.SetMemory(num2 + num7, buffer5);
                    num5 = num2 + num7;
                    num7 += (uint)buffer5.Length;
                }
                if (int_5 >= 1)
                {
                    Xconsole.WriteInt32(num2 + num7, (int)num3);
                    num6 = num2 + num7;
                    num7 += 4;
                }
                if (int_5 >= 2)
                {
                    Xconsole.WriteInt32(num2 + num7, (int)num4);
                    num7 += 4;
                }
                if (int_5 == 3)
                {
                    Xconsole.WriteInt32(num2 + num7, (int)num5);
                    num7 += 4;
                }
                object[] arguments = new object[] { int_4, num8, num9, int_5, num6, int_6, int_7, num2, num2 + 0x1c };
                XboxExtention.Call<uint>(address, arguments);
                byte[] buffer8 = new byte[num7];
                Xconsole.SetMemory(num2, buffer8);
            }
            catch
            {

            }
        }
        public static void Show(string Message)
        {
            Show(Message, true);
        }

        public static void Show(string Message, bool ISON)
        {
            if (ISON == true)
            {
                Show(Message, XNotiyLogo.FLASHING_XBOX_LOGO);
            }
            else
            {

            }
        }
        public static void Show(string Message, XNotiyLogo Logo, bool ISON)
        {
            if (ISON == true)
            {
                Show(Message, Logo);
            }
            else
            {

            }
        }

        public static void Show(string message, XNotiyLogo Logo)
        {
            string command = "consolefeatures ver=2" + " type=12 params=\"A\\0\\A\\2\\" + (int)2 + "/" + message.Length + "\\" + Functions.ConvertStringToHex(message, Encoding.ASCII) + "\\" + (int)1 + "\\";
            switch (Logo)
            {
                case XNotiyLogo.XBOX_LOGO:
                    command += XNotiyLogo.XBOX_LOGO + "\\\"";
                    break;
                case XNotiyLogo.NEW_MESSAGE_LOGO:
                    command += XNotiyLogo.NEW_MESSAGE_LOGO + "\\\"";
                    break;
                case XNotiyLogo.FRIEND_REQUEST_LOGO:
                    command += XNotiyLogo.FRIEND_REQUEST_LOGO + "\\\"";
                    break;
                case XNotiyLogo.NEW_MESSAGE:
                    command += XNotiyLogo.NEW_MESSAGE + "\\\"";
                    break;
                case XNotiyLogo.FLASHING_XBOX_LOGO:
                    command += XNotiyLogo.FLASHING_XBOX_LOGO + "\\\"";
                    break;
                case XNotiyLogo.GAMERTAG_SENT_YOU_A_MESSAGE:
                    command += XNotiyLogo.GAMERTAG_SENT_YOU_A_MESSAGE + "\\\"";
                    break;
                case XNotiyLogo.GAMERTAG_SINGED_OUT:
                    command += XNotiyLogo.GAMERTAG_SINGED_OUT + "\\\"";
                    break;
                case XNotiyLogo.GAMERTAG_SIGNEDIN:
                    command += XNotiyLogo.GAMERTAG_SIGNEDIN + "\\\"";
                    break;
                case XNotiyLogo.GAMERTAG_SIGNED_INTO_XBOX_LIVE:
                    command += XNotiyLogo.GAMERTAG_SIGNED_INTO_XBOX_LIVE + "\\\"";
                    break;
                case XNotiyLogo.GAMERTAG_SIGNED_IN_OFFLINE:
                    command += XNotiyLogo.GAMERTAG_SIGNED_IN_OFFLINE + "\\\"";
                    break;
                case XNotiyLogo.GAMERTAG_WANTS_TO_CHAT:
                    command += XNotiyLogo.GAMERTAG_WANTS_TO_CHAT + "\\\"";
                    break;
                case XNotiyLogo.DISCONNECTED_FROM_XBOX_LIVE:
                    command += XNotiyLogo.DISCONNECTED_FROM_XBOX_LIVE + "\\\"";
                    break;
                case XNotiyLogo.DOWNLOAD:
                    command += XNotiyLogo.DOWNLOAD + "\\\"";
                    break;
                case XNotiyLogo.FLASHING_MUSIC_SYMBOL:
                    command += XNotiyLogo.FLASHING_MUSIC_SYMBOL + "\\\"";
                    break;
                case XNotiyLogo.FLASHING_HAPPY_FACE:
                    command += XNotiyLogo.FLASHING_HAPPY_FACE + "\\\"";
                    break;
                case XNotiyLogo.FLASHING_FROWNING_FACE:
                    command += XNotiyLogo.FLASHING_FROWNING_FACE + "\\\"";
                    break;
                case XNotiyLogo.FLASHING_DOUBLE_SIDED_HAMMER:
                    command += XNotiyLogo.GAMERTAG_WANTS_TO_CHAT + "\\\"";
                    break;
                case XNotiyLogo.GAMERTAG_WANTS_TO_CHAT_2:
                    command += XNotiyLogo.GAMERTAG_WANTS_TO_CHAT_2 + "\\\"";
                    break;
                case XNotiyLogo.PLEASE_REINSERT_MEMORY_UNIT:
                    command += XNotiyLogo.PLEASE_REINSERT_MEMORY_UNIT + "\\\"";
                    break;
                case XNotiyLogo.PLEASE_RECONNECT_CONTROLLERM:
                    command += XNotiyLogo.PLEASE_RECONNECT_CONTROLLERM + "\\\"";
                    break;
                case XNotiyLogo.GAMERTAG_HAS_JOINED_CHAT:
                    command += XNotiyLogo.GAMERTAG_HAS_JOINED_CHAT + "\\\"";
                    break;
                case XNotiyLogo.GAMERTAG_HAS_LEFT_CHAT:
                    command += XNotiyLogo.GAMERTAG_HAS_LEFT_CHAT + "\\\"";
                    break;
                case XNotiyLogo.GAME_INVITE_SENT:
                    command += XNotiyLogo.GAME_INVITE_SENT + "\\\"";
                    break;
                case XNotiyLogo.FLASH_LOGO:
                    command += XNotiyLogo.FLASH_LOGO + "\\\"";
                    break;
                case XNotiyLogo.PAGE_SENT_TO:
                    command += XNotiyLogo.PAGE_SENT_TO + "\\\"";
                    break;
                case XNotiyLogo.FOUR_2:
                    command += XNotiyLogo.FOUR_2 + "\\\"";
                    break;
                case XNotiyLogo.FOUR_3:
                    command += XNotiyLogo.FOUR_3 + "\\\"";
                    break;
                case XNotiyLogo.ACHIEVEMENT_UNLOCKED:
                    command += XNotiyLogo.ACHIEVEMENT_UNLOCKED + "\\\"";
                    break;
                case XNotiyLogo.FOUR_9:
                    command += XNotiyLogo.FOUR_9 + "\\\"";
                    break;
                case XNotiyLogo.GAMERTAG_WANTS_TO_TALK_IN_VIDEO_KINECT:
                    command += XNotiyLogo.GAMERTAG_WANTS_TO_TALK_IN_VIDEO_KINECT + "\\\"";
                    break;
                case XNotiyLogo.VIDEO_CHAT_INVITE_SENT:
                    command += XNotiyLogo.VIDEO_CHAT_INVITE_SENT + "\\\"";
                    break;
                case XNotiyLogo.READY_TO_PLAY:
                    command += XNotiyLogo.READY_TO_PLAY + "\\\"";
                    break;
                case XNotiyLogo.CANT_DOWNLOAD_X:
                    command += XNotiyLogo.CANT_DOWNLOAD_X + "\\\"";
                    break;
                case XNotiyLogo.DOWNLOAD_STOPPED_FOR_X:
                    command += XNotiyLogo.DOWNLOAD_STOPPED_FOR_X + "\\\"";
                    break;
                case XNotiyLogo.FLASHING_XBOX_CONSOLE:
                    command += XNotiyLogo.FLASHING_XBOX_CONSOLE + "\\\"";
                    break;
                case XNotiyLogo.X_SENT_YOU_A_GAME_MESSAGE:
                    command += XNotiyLogo.X_SENT_YOU_A_GAME_MESSAGE + "\\\"";
                    break;
                case XNotiyLogo.DEVICE_FULL:
                    command += XNotiyLogo.DEVICE_FULL + "\\\"";
                    break;
                case XNotiyLogo.FOUR_7:
                    command += XNotiyLogo.FOUR_7 + "\\\"";
                    break;
                case XNotiyLogo.FLASHING_CHAT_ICON:
                    command += XNotiyLogo.FLASHING_CHAT_ICON + "\\\"";
                    break;
                case XNotiyLogo.ACHIEVEMENTS_UNLOCKED:
                    command += XNotiyLogo.ACHIEVEMENTS_UNLOCKED + "\\\"";
                    break;
                case XNotiyLogo.X_HAS_SENT_YOU_A_NUDGE:
                    command += XNotiyLogo.X_HAS_SENT_YOU_A_NUDGE + "\\\"";
                    break;
                case XNotiyLogo.MESSENGER_DISCONNECTED:
                    command += XNotiyLogo.MESSENGER_DISCONNECTED + "\\\"";
                    break;
                case XNotiyLogo.BLANK:
                    command += XNotiyLogo.BLANK + "\\\"";
                    break;
                case XNotiyLogo.CANT_SIGN_IN_MESSENGER:
                    command += XNotiyLogo.CANT_SIGN_IN_MESSENGER + "\\\"";
                    break;
                case XNotiyLogo.MISSED_MESSENGER_CONVERSATION:
                    command += XNotiyLogo.MISSED_MESSENGER_CONVERSATION + "\\\"";
                    break;
                case XNotiyLogo.FAMILY_TIMER_X_TIME_REMAINING:
                    command += XNotiyLogo.FAMILY_TIMER_X_TIME_REMAINING + "\\\"";
                    break;
                case XNotiyLogo.DISCONNECTED_XBOX_LIVE_11_MINUTES_REMAINING:
                    command += XNotiyLogo.DISCONNECTED_XBOX_LIVE_11_MINUTES_REMAINING + "\\\"";
                    break;
                case XNotiyLogo.KINECT_HEALTH_EFFECTS:
                    command += XNotiyLogo.KINECT_HEALTH_EFFECTS + "\\\"";
                    break;
                case XNotiyLogo.FOUR_5:
                    command += XNotiyLogo.FOUR_5 + "\\\"";
                    break;
                case XNotiyLogo.GAMERTAG_WANTS_YOU_TO_JOIN_AN_XBOX_LIVE_PARTY:
                    command += XNotiyLogo.GAMERTAG_WANTS_YOU_TO_JOIN_AN_XBOX_LIVE_PARTY + "\\\"";
                    break;
                case XNotiyLogo.PARTY_INVITE_SENT:
                    command += XNotiyLogo.PARTY_INVITE_SENT + "\\\"";
                    break;
                case XNotiyLogo.GAME_INVITE_SENT_TO_XBOX_LIVE_PARTY:
                    command += XNotiyLogo.GAME_INVITE_SENT_TO_XBOX_LIVE_PARTY + "\\\"";
                    break;
                case XNotiyLogo.KICKED_FROM_XBOX_LIVE_PARTY:
                    command += XNotiyLogo.KICKED_FROM_XBOX_LIVE_PARTY + "\\\"";
                    break;
                case XNotiyLogo.NULLED:
                    command += XNotiyLogo.NULLED + "\\\"";
                    break;
                case XNotiyLogo.DISCONNECTED_XBOX_LIVE_PARTY:
                    command += XNotiyLogo.DISCONNECTED_XBOX_LIVE_PARTY + "\\\"";
                    break;
                case XNotiyLogo.DOWNLOADED:
                    command += XNotiyLogo.DOWNLOADED + "\\\"";
                    break;
                case XNotiyLogo.CANT_CONNECT_XBL_PARTY:
                    command += XNotiyLogo.CANT_CONNECT_XBL_PARTY + "\\\"";
                    break;
                case XNotiyLogo.GAMERTAG_HAS_JOINED_XBL_PARTY:
                    command += XNotiyLogo.GAMERTAG_HAS_JOINED_XBL_PARTY + "\\\"";
                    break;
                case XNotiyLogo.GAMERTAG_HAS_LEFT_XBL_PARTY:
                    command += XNotiyLogo.GAMERTAG_HAS_LEFT_XBL_PARTY + "\\\"";
                    break;
                case XNotiyLogo.GAMER_PICTURE_UNLOCKED:
                    command += XNotiyLogo.GAMER_PICTURE_UNLOCKED + "\\\"";
                    break;
                case XNotiyLogo.AVATAR_AWARD_UNLOCKED:
                    command += XNotiyLogo.AVATAR_AWARD_UNLOCKED + "\\\"";
                    break;
                case XNotiyLogo.JOINED_XBL_PARTY:
                    command += XNotiyLogo.JOINED_XBL_PARTY + "\\\"";
                    break;
                case XNotiyLogo.PLEASE_REINSERT_USB_STORAGE_DEVICE:
                    command += XNotiyLogo.PLEASE_REINSERT_USB_STORAGE_DEVICE + "\\\"";
                    break;
                case XNotiyLogo.PLAYER_MUTED:
                    command += XNotiyLogo.PLAYER_MUTED + "\\\"";
                    break;
                case XNotiyLogo.PLAYER_UNMUTED:
                    command += XNotiyLogo.PLAYER_UNMUTED + "\\\"";
                    break;
                case XNotiyLogo.FLASHING_CHAT_SYMBOL:
                    command += XNotiyLogo.FLASHING_CHAT_SYMBOL + "\\\"";
                    break;
                case XNotiyLogo.UPDATING:
                    command += XNotiyLogo.UPDATING + "\\\"";
                    break;
                default:
                    command += "\\\"";
                    break;
            }
            Xbox.SendTextCommand(command);
        }
    }
}
