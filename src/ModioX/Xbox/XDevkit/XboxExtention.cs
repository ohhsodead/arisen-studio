#region Misc
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace XDevkit
{
    public static class XboxExtention
    {
        private static HashSet<Type> ValidReturnTypes { get; set; }
        private static object CallArgs(bool SystemThread, uint Type, Type t, string module, int ordinal, uint Address, uint ArraySize, params object[] Arguments)
        {
            uint Void = 0;
            uint Int = 1;
            uint Float = 3;
            uint ByteArray = 7;
            uint Uint64 = 8;
            uint Uint64Array = 9;
            uint Version = 2;
            if (!IsValidReturnType(t))
                throw new Exception("Invalid type " + t.Name + Environment.NewLine + "supports Only: bool, byte, short, int, long, ushort, uint, ulong, float, double");
            Xbox.ConnectTimeout = Xbox.ConversationTimeout = 4000000U;
            object[] objArray1 = new object[13];
            objArray1[0] = "consolefeatures ver=";
            objArray1[1] = Version;
            objArray1[2] = " type=";
            objArray1[3] = Type;
            objArray1[4] = SystemThread ? " system" : "";
            object[] objArray2 = objArray1;
            string str1;
            if (module == null)
                str1 = "";
            else
                str1 = " module=\"" + module + "\" ord=" + ordinal;
            objArray2[5] = str1;
            objArray1[6] = " as=";
            objArray1[7] = ArraySize;
            objArray1[8] = " params=\"A\\";
            objArray1[9] = Address.ToString("X");
            objArray1[10] = "\\A\\";
            objArray1[11] = Arguments.Length;
            objArray1[12] = "\\";
            string str2 = string.Concat(objArray1);
            if (Arguments.Length > 37)
                throw new Exception("Can not use more than 37 paramaters in a call");
            foreach (object o in Arguments)
            {
                bool flag1 = false;
                if (o is uint num)
                {

                    str2 = str2 + Int + "\\" + Functions.UIntToInt(num) + "\\";
                    flag1 = true;
                }
                if (o is int || o is bool || o is byte)
                {
                    if (o is bool flag)
                        str2 = str2 + Int + "/" + Convert.ToInt32(flag) + "\\";
                    else
                        str2 = str2 + Int + "\\" + (o is byte ? Convert.ToByte(o).ToString() : Convert.ToInt32(o).ToString()) + "\\";
                    flag1 = true;
                }
                else if (o is int[] || o is uint[])
                {
                    byte[] numArray = Functions.IntArrayToByte((int[])o);
                    string str3 = str2 + ByteArray.ToString() + "/" + numArray.Length + "\\";
                    for (int index = 0; index < numArray.Length; ++index)
                        str3 += numArray[index].ToString("X2");
                    str2 = str3 + "\\";
                    flag1 = true;
                }
                else if (o is string)
                {
                    string str3 = (string)o;
                    str2 = str2 + ByteArray.ToString() + "/" + str3.Length + "\\" + ((string)o).ToHexString() + "\\";
                    flag1 = true;
                }
                else if (o is double)
                {
                    str2 = str2 + Float.ToString() + "\\" + o.ToString() + "\\";
                    flag1 = true;
                }
                else if (o is float)
                {
                    str2 = str2 + Float.ToString() + "\\" + o.ToString() + "\\";
                    flag1 = true;
                }
                else if (o is float[])
                {
                    float[] numArray = (float[])o;
                    string str3 = str2 + ByteArray.ToString() + "/" + (numArray.Length * 4).ToString() + "\\";
                    for (int index1 = 0; index1 < numArray.Length; ++index1)
                    {
                        byte[] bytes = BitConverter.GetBytes(numArray[index1]);
                        Array.Reverse(bytes);
                        for (int index2 = 0; index2 < 4; ++index2)
                            str3 += bytes[index2].ToString("X2");
                    }
                    str2 = str3 + "\\";
                    flag1 = true;
                }
                else if (o is byte[])
                {
                    byte[] numArray = (byte[])o;
                    string str3 = str2 + ByteArray.ToString() + "/" + numArray.Length + "\\";
                    for (int index = 0; index < numArray.Length; ++index)
                        str3 += numArray[index].ToString("X2");
                    str2 = str3 + "\\";
                    flag1 = true;
                }
                if (!flag1)
                    str2 = str2 + Uint64.ToString() + "\\" + Functions.ConvertToUInt64(o).ToString() + "\\";
            }
            string Command = str2 + "\"";
            string String = Xbox.SendTextCommand(Command);
            uint num1;
            for (string _Ptr = "buf_addr="; String.Contains(_Ptr); String = Xbox.SendTextCommand("consolefeatures " + _Ptr + "0x" + num1.ToString("X")))
            {
                Thread.Sleep(250);
                num1 = uint.Parse(String.Substring(String.find(_Ptr) + _Ptr.Length), NumberStyles.HexNumber);
            }
            Xbox.ConversationTimeout = 2000U;
            Xbox.ConnectTimeout = 5000U;
            switch (Type)
            {
                case 1:
                    uint num2 = uint.Parse(String.Substring(String.find(" ") + 1), NumberStyles.HexNumber);
                    if (t == typeof(uint))
                        return num2;
                    if (t == typeof(int))
                        return Functions.UIntToInt(num2);
                    if (t == typeof(short))
                        return short.Parse(String.Substring(String.find(" ") + 1), NumberStyles.HexNumber);
                    if (t == typeof(ushort))
                        return ushort.Parse(String.Substring(String.find(" ") + 1), NumberStyles.HexNumber);
                    break;
                case 2:
                    string str4 = String.Substring(String.find(" ") + 1);
                    if (t == typeof(string))
                        return str4;
                    if (t == typeof(char[]))
                        return str4.ToCharArray();
                    break;
                case 3:
                    if (t == typeof(double))
                        return double.Parse(String.Substring(String.find(" ") + 1));
                    if (t == typeof(float))
                        return float.Parse(String.Substring(String.find(" ") + 1));
                    break;
                case 4:
                    byte num3 = byte.Parse(String.Substring(String.find(" ") + 1), NumberStyles.HexNumber);
                    if (t == typeof(byte))
                        return num3;
                    if (t == typeof(char))
                        return (char)num3;
                    break;
                case 8:
                    if (t == typeof(long))
                        return long.Parse(String.Substring(String.find(" ") + 1), NumberStyles.HexNumber);
                    if (t == typeof(ulong))
                        return ulong.Parse(String.Substring(String.find(" ") + 1), NumberStyles.HexNumber);
                    break;
            }
            switch (Type)
            {
                case 5:
                    string str5 = String.Substring(String.find(" ") + 1);
                    int index3 = 0;
                    string s1 = "";
                    uint[] numArray1 = new uint[8];
                    foreach (char ch in str5)
                    {
                        switch (ch)
                        {
                            case ',':
                            case ';':
                                numArray1[index3] = uint.Parse(s1, NumberStyles.HexNumber);
                                ++index3;
                                s1 = "";
                                break;
                            default:
                                s1 += ch.ToString();
                                break;
                        }
                        if (ch == ';')
                            break;
                    }
                    return numArray1;
                case 6:
                    string str6 = String.Substring(String.find(" ") + 1);
                    int index4 = 0;
                    string s2 = "";
                    float[] numArray2 = new float[ArraySize];
                    foreach (char ch in str6)
                    {
                        switch (ch)
                        {
                            case ',':
                            case ';':
                                numArray2[index4] = float.Parse(s2);
                                ++index4;
                                s2 = "";
                                break;
                            default:
                                s2 += ch.ToString();
                                break;
                        }
                        if (ch == ';')
                            break;
                    }
                    return numArray2;
                case 7:
                    string str7 = String.Substring(String.find(" ") + 1);
                    int index5 = 0;
                    string s3 = "";
                    byte[] numArray3 = new byte[ArraySize];
                    foreach (char ch in str7)
                    {
                        switch (ch)
                        {
                            case ',':
                            case ';':
                                numArray3[index5] = byte.Parse(s3);
                                ++index5;
                                s3 = "";
                                break;
                            default:
                                s3 += ch.ToString();
                                break;
                        }
                        if (ch == ';')
                            break;
                    }
                    return numArray3;
                default:
                    if ((int)Type == (int)Uint64Array)
                    {
                        string str3 = String.Substring(String.find(" ") + 1);
                        int index1 = 0;
                        string s4 = "";
                        ulong[] numArray4 = new ulong[ArraySize];
                        foreach (char ch in str3)
                        {
                            switch (ch)
                            {
                                case ',':
                                case ';':
                                    numArray4[index1] = ulong.Parse(s4);
                                    ++index1;
                                    s4 = "";
                                    break;
                                default:
                                    s4 += ch.ToString();
                                    break;
                            }
                            if (ch == ';')
                                break;
                        }
                        if (t == typeof(ulong))
                            return numArray4;
                        if (t == typeof(long))
                        {
                            long[] numArray5 = new long[ArraySize];
                            for (int index2 = 0; index2 < ArraySize; ++index2)
                                numArray5[index2] = BitConverter.ToInt64(BitConverter.GetBytes(numArray4[index2]), 0);
                            return numArray5;
                        }
                    }
                    return (int)Type == (int)Void ? 0 : ulong.Parse(String.Substring(String.find(" ") + 1), NumberStyles.HexNumber);
            }
        }
        private static uint TypeToType<T>(bool Array) where T : struct
        {
            uint Int = 1;
            uint String = 2;
            uint Float = 3;
            uint Byte = 4;
            uint IntArray = 5;
            uint FloatArray = 6;
            uint ByteArray = 7;
            uint Uint64 = 8;
            uint Uint64Array = 9;
            Type type = typeof(T);
            if (type == typeof(int) || type == typeof(uint) || (type == typeof(short) || type == typeof(ushort)))
                return Array ? IntArray : Int;
            if (type == typeof(string) || type == typeof(char[]))
                return String;
            return type == typeof(float) || type == typeof(double) ? (Array ? FloatArray : Float) : (type == typeof(byte) || type == typeof(char) ? (Array ? ByteArray : Byte) : ((type == typeof(ulong) || type == typeof(long)) && Array ? Uint64Array : Uint64));
        }
        public static void CallVoid(string module, int ordinal, params object[] Arguments)
        {
            uint Void = 0;
            CallArgs(true, Void, typeof(void), module, ordinal, 0U, 0U, Arguments);
        }
        public static void CallVoid(uint Address, params object[] Arguments)
        { CallArgs(true, 0, typeof(void), null, 0, Address, 0, Arguments); }

        public static void CallVoid(ThreadType Type, string module, int ordinal, params object[] Arguments)
        { CallArgs(Type == ThreadType.System, 0/*Void*/, typeof(void), module, ordinal, 0, 0, Arguments); }

        public static int find(this string String, string _Ptr)
        {
            if (_Ptr.Length == 0 || String.Length == 0)
            {
                return -1;
            }
            for (int i = 0; i < String.Length; i++)
            {
                if (String[i] == _Ptr[0])
                {
                    bool flag = true;
                    for (int j = 0; j < _Ptr.Length; j++)
                    {
                        if (String[i + j] != _Ptr[j])
                        {
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        internal static bool IsValidReturnType(Type t) { return ValidReturnTypes.Contains(t); }


        public static void Push(this byte[] InArray, out byte[] OutArray, byte Value)
        {
            OutArray = new byte[InArray.Length + 1];
            InArray.CopyTo(OutArray, 0);
            OutArray[InArray.Length] = Value;
        }

        public static T Call<T>(string module,int ordinal,params object[] Arguments) where T : struct
        {
            return (T)CallArgs(true, TypeToType<T>(false), typeof(T), module, ordinal, 0U, 0U, Arguments);
        }
    }
}
#endregion
/// <summary>
/// Module information.
/// </summary>
public class ModuleInfo
{
    /// <summary>
    /// Name of the module that was loaded.
    /// </summary>
    public string Name;

    /// <summary>
    /// Address that the module was loaded to.
    /// </summary>
    public uint BaseAddress;

    /// <summary>
    /// Size of the module.
    /// </summary>
    public uint Size;

    /// <summary>
    /// Time stamp of the module.
    /// </summary>
    public DateTime TimeStamp;

    /// <summary>
    /// Checksum of the module.
    /// </summary>
    public uint Checksum;

    /// <summary>
    /// Sections contained within the module.
    /// </summary>
    public System.Collections.Generic.List<ModuleSection> Sections;

    public override string ToString()
    {
        return
            "{ Name: " + Name +
            " BaseAddress: " + BaseAddress +
            " Size: " + Size +
            " TimeStamp: " + TimeStamp.ToString() +
            " Checksum: " + Checksum +
            " }";
    }
};
/// <summary>
/// Module section information.
/// </summary>
public class ModuleSection
{
    public string Name;
    public uint Base;
    public uint Size;
    public uint Index;
    public uint Flags;

    public override string ToString()
    {
        return
            "{ Name: " + Name +
            " Base: " + Base +
            " Size: " + Size +
            " Index: " + Index +
            " Flags: " + Flags +
            " }";
    }
};