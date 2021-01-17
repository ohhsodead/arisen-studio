namespace XDevkit
{
    using System;
    using System.Runtime.InteropServices;

    internal static class DXTDecoder
    {
        public static byte[] ConvertFromLinearTexture(byte[] data, int width, int height, TextureFormat texture) => 
            ModifyLinearTexture(data, width, height, texture, false);

        public static byte[] ConvertToLinearTexture(byte[] data, int width, int height, TextureFormat texture) => 
            ModifyLinearTexture(data, width, height, texture, true);

        public static byte[] DecodeA1R5G5B5(byte[] data, int width, int height)
        {
            byte[] buffer = new byte[(width * height) * 4];
            for (int i = 0; i < ((width * height) * 2); i += 2)
            {
                short num2 = (short) (data[i] | (data[i + 1] << 8));
                buffer[i * 2] = (byte) (num2 & 0x1f);
                buffer[(i * 2) + 1] = (byte) ((num2 >> 5) & 0x3f);
                buffer[(i * 2) + 2] = (byte) ((num2 >> 11) & 0x1f);
                buffer[(i * 2) + 3] = 0xff;
            }
            return buffer;
        }

        public static byte[] DecodeA4R4G4B4(byte[] data, int width, int height)
        {
            byte[] buffer = new byte[(width * height) * 4];
            for (int i = 0; i < ((width * height) * 2); i += 2)
            {
                buffer[(i * 2) + 3] = (byte) (data[i] & 240);
                buffer[(i * 2) + 2] = (byte) (data[i] & 15);
                buffer[(i * 2) + 1] = (byte) (data[i + 1] & 240);
                buffer[i * 2] = (byte) (data[i + 1] & 15);
            }
            return buffer;
        }

        public static byte[] DecodeA8(byte[] data, int width, int height)
        {
            byte[] buffer = new byte[(height * width) * 4];
            for (int i = 0; i < (height * width); i++)
            {
                int index = i * 4;
                buffer[index] = 0xff;
                buffer[index + 1] = 0xff;
                buffer[index + 2] = 0xff;
                buffer[index + 3] = data[i];
            }
            return buffer;
        }

        public static byte[] DecodeA8Y8(byte[] data, int width, int height)
        {
            byte[] buffer = new byte[(height * width) * 4];
            for (int i = 0; i < ((height * width) * 2); i += 2)
            {
                buffer[i * 2] = data[i + 1];
                buffer[(i * 2) + 1] = data[i + 1];
                buffer[(i * 2) + 2] = data[i + 1];
                buffer[(i * 2) + 3] = data[i];
            }
            return buffer;
        }

        public static byte[] DecodeAY8(byte[] data, int width, int height)
        {
            byte[] buffer = new byte[(height * width) * 4];
            for (int i = 0; i < (height * width); i++)
            {
                int index = i * 4;
                buffer[index] = data[i];
                buffer[index + 1] = data[i];
                buffer[index + 2] = data[i];
                buffer[index + 3] = data[i];
            }
            return buffer;
        }

        public static byte[] DecodeCTX1(byte[] data, int width, int height)
        {
            byte[] buffer = new byte[(width * height) * 4];
            int index = 0;
            for (int i = 0; i < (width * height); i += 0x10)
            {
                int num3 = (data[index + 1] << 8) | data[index];
                int num4 = (data[index + 3] << 8) | data[index + 2];
                RGBAColor[] colorArray = new RGBAColor[4];
                colorArray[0].R = data[index];
                colorArray[0].G = data[index + 1];
                colorArray[1].R = data[index + 2];
                colorArray[1].G = data[index + 3];
                if (num3 > num4)
                {
                    colorArray[2] = GradientColors(colorArray[0], colorArray[1]);
                    colorArray[3] = GradientColors(colorArray[1], colorArray[0]);
                }
                else
                {
                    colorArray[2] = GradientColorsHalf(colorArray[0], colorArray[1]);
                    colorArray[3] = colorArray[0];
                }
                int num5 = ((data[index + 5] | (data[index + 4] << 8)) | (data[index + 7] << 0x10)) | (data[index + 6] << 0x18);
                int num6 = i / 0x10;
                int num7 = num6 % (width / 4);
                int num8 = (num6 - num7) / (width / 4);
                int num9 = (height < 4) ? height : 4;
                int num10 = (width < 4) ? width : 4;
                for (int j = 0; j < num9; j++)
                {
                    for (int k = 0; k < num10; k++)
                    {
                        RGBAColor color = colorArray[num5 & 3];
                        num5 = num5 >> 2;
                        int num13 = (((((num8 * 4) + j) * width) + (num7 * 4)) + k) * 4;
                        float num14 = ((((float) color.R) / 255f) * 2f) - 1f;
                        float num15 = ((((float) color.G) / 255f) * 2f) - 1f;
                        float num16 = (float) Math.Sqrt((double) Math.Max(0f, Math.Min((float) 1f, (float) ((1f - (num14 * num14)) - (num15 * num15)))));
                        buffer[num13] = (byte) (((num16 + 1f) / 2f) * 255f);
                        buffer[num13 + 1] = (byte) color.G;
                        buffer[num13 + 2] = (byte) color.R;
                        buffer[num13 + 3] = 0xff;
                    }
                }
                index += 8;
            }
            return buffer;
        }

        public static byte[] DecodeDXN(byte[] data, int width, int height)
        {
            byte[] buffer = new byte[(height * width) * 4];
            int num = width / 4;
            if (num == 0)
            {
                num = 1;
            }
            for (int i = 0; i < (width * height); i += 0x10)
            {
                byte num3 = data[i + 1];
                byte num4 = data[i];
                byte[] buffer2 = new byte[0x10];
                int index = ((data[i + 5] << 0x10) | (data[i + 2] << 8)) | data[i + 3];
                int num6 = 0;
                while (num6 < 8)
                {
                    buffer2[num6] = (byte) (index & 7);
                    index = index >> 3;
                    num6++;
                }
                index = ((data[i + 6] << 0x10) | (data[i + 7] << 8)) | data[i + 4];
                while (num6 < 0x10)
                {
                    buffer2[num6] = (byte) (index & 7);
                    index = index >> 3;
                    num6++;
                }
                byte num7 = data[i + 9];
                byte num8 = data[i + 8];
                byte[] buffer3 = new byte[0x10];
                index = ((data[i + 13] << 0x10) | (data[i + 10] << 8)) | data[i + 11];
                num6 = 0;
                while (num6 < 8)
                {
                    buffer3[num6] = (byte) (index & 7);
                    index = index >> 3;
                    num6++;
                }
                index = ((data[i + 14] << 0x10) | (data[i + 15] << 8)) | data[i + 12];
                while (num6 < 0x10)
                {
                    buffer3[num6] = (byte) (index & 7);
                    index = index >> 3;
                    num6++;
                }
                byte[] buffer4 = new byte[8];
                buffer4[0] = num3;
                buffer4[1] = num4;
                if (buffer4[0] > buffer4[1])
                {
                    buffer4[2] = (byte) (((num4 - num3) * 0.1428571f) + num3);
                    buffer4[3] = (byte) (((num4 - num3) * 0.2857143f) + num3);
                    buffer4[4] = (byte) (((num4 - num3) * 0.4285714f) + num3);
                    buffer4[5] = (byte) (((num4 - num3) * 0.5714286f) + num3);
                    buffer4[6] = (byte) (((num4 - num3) * 0.7142857f) + num3);
                    buffer4[7] = (byte) (((num4 - num3) * 0.8571429f) + num3);
                }
                else
                {
                    buffer4[2] = (byte) (((num4 - num3) * 0.2f) + num3);
                    buffer4[3] = (byte) (((num4 - num3) * 0.4f) + num3);
                    buffer4[4] = (byte) (((num4 - num3) * 0.6f) + num3);
                    buffer4[5] = (byte) (((num4 - num3) * 0.8f) + num3);
                    buffer4[6] = num3;
                    buffer4[7] = num4;
                }
                byte[] buffer5 = new byte[8];
                buffer5[0] = num7;
                buffer5[1] = num8;
                if (buffer5[0] > buffer5[1])
                {
                    buffer5[2] = (byte) (((num8 - num7) * 0.1428571f) + num7);
                    buffer5[3] = (byte) (((num8 - num7) * 0.2857143f) + num7);
                    buffer5[4] = (byte) (((num8 - num7) * 0.4285714f) + num7);
                    buffer5[5] = (byte) (((num8 - num7) * 0.5714286f) + num7);
                    buffer5[6] = (byte) (((num8 - num7) * 0.7142857f) + num7);
                    buffer5[7] = (byte) (((num8 - num7) * 0.8571429f) + num7);
                }
                else
                {
                    buffer5[2] = (byte) (((num8 - num7) * 0.2f) + num7);
                    buffer5[3] = (byte) (((num8 - num7) * 0.4f) + num7);
                    buffer5[4] = (byte) (((num8 - num7) * 0.6f) + num7);
                    buffer5[5] = (byte) (((num8 - num7) * 0.8f) + num7);
                    buffer5[6] = num7;
                    buffer5[7] = num8;
                }
                int num9 = i / 0x10;
                int num10 = num9 % num;
                int num11 = (num9 - num10) / num;
                int num12 = (height < 4) ? height : 4;
                int num13 = (width < 4) ? width : 4;
                for (int j = 0; j < num12; j++)
                {
                    for (int k = 0; k < num13; k++)
                    {
                        RGBAColor color;
                        color.R = buffer4[buffer2[(j * num12) + k]];
                        color.G = buffer5[buffer3[(j * num12) + k]];
                        float num16 = ((((float) color.R) / 255f) * 2f) - 1f;
                        float num17 = ((((float) color.G) / 255f) * 2f) - 1f;
                        float num18 = (float) Math.Sqrt((double) Math.Max(0f, Math.Min((float) 1f, (float) ((1f - (num16 * num16)) - (num17 * num17)))));
                        color.B = (byte) (((num18 + 1f) / 2f) * 255f);
                        color.A = 0xff;
                        index = (((((num11 * 4) + j) * width) + (num10 * 4)) + k) * 4;
                        buffer[index] = (byte) color.B;
                        buffer[index + 1] = (byte) color.G;
                        buffer[index + 2] = (byte) color.R;
                        buffer[index + 3] = (byte) color.A;
                    }
                }
            }
            return buffer;
        }

        public static byte[] DecodeDXT1(byte[] data, int width, int height)
        {
            byte[] buffer = new byte[(width * height) * 4];
            int num = width / 4;
            int num2 = height / 4;
            for (int i = 0; i < num2; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    int index = ((i * num) + j) * 8;
                    uint num6 = (uint) ((data[index] << 8) + data[index + 1]);
                    uint num7 = (uint) ((data[index + 2] << 8) + data[index + 3]);
                    uint num8 = BitConverter.ToUInt32(data, index + 4);
                    ushort num9 = 0;
                    ushort num10 = 0;
                    ushort num11 = 0;
                    ushort num12 = 0;
                    ushort num13 = 0;
                    ushort num14 = 0;
                    num9 = (ushort) (8 * (num6 & 0x1f));
                    num10 = (ushort) (4 * ((num6 >> 5) & 0x3f));
                    num11 = (ushort) (8 * ((num6 >> 11) & 0x1f));
                    num12 = (ushort) (8 * (num7 & 0x1f));
                    num13 = (ushort) (4 * ((num7 >> 5) & 0x3f));
                    num14 = (ushort) (8 * ((num7 >> 11) & 0x1f));
                    for (int k = 0; k < 4; k++)
                    {
                        int num16 = k ^ 1;
                        for (int m = 0; m < 4; m++)
                        {
                            int num18 = ((width * ((i * 4) + num16)) * 4) + (((j * 4) + m) * 4);
                            switch ((num8 & 3))
                            {
                                case 0:
                                    buffer[num18] = (byte) num9;
                                    buffer[num18 + 1] = (byte) num10;
                                    buffer[num18 + 2] = (byte) num11;
                                    buffer[num18 + 3] = 0xff;
                                    goto Label_023B;

                                case 1:
                                    buffer[num18] = (byte) num12;
                                    buffer[num18 + 1] = (byte) num13;
                                    buffer[num18 + 2] = (byte) num14;
                                    buffer[num18 + 3] = 0xff;
                                    goto Label_023B;

                                case 2:
                                    buffer[num18 + 3] = 0xff;
                                    if (num6 <= num7)
                                    {
                                        break;
                                    }
                                    buffer[num18] = (byte) (((2 * num9) + num12) / 3);
                                    buffer[num18 + 1] = (byte) (((2 * num10) + num13) / 3);
                                    buffer[num18 + 2] = (byte) (((2 * num11) + num14) / 3);
                                    goto Label_023B;

                                case 3:
                                    if (num6 <= num7)
                                    {
                                        goto Label_021D;
                                    }
                                    buffer[num18] = (byte) ((num9 + (2 * num12)) / 3);
                                    buffer[num18 + 1] = (byte) ((num10 + (2 * num13)) / 3);
                                    buffer[num18 + 2] = (byte) ((num11 + (2 * num14)) / 3);
                                    buffer[num18 + 3] = 0xff;
                                    goto Label_023B;

                                default:
                                    goto Label_023B;
                            }
                            buffer[num18] = (byte) ((num9 + num12) / 2);
                            buffer[num18 + 1] = (byte) ((num10 + num13) / 2);
                            buffer[num18 + 2] = (byte) ((num11 + num14) / 2);
                            goto Label_023B;
                        Label_021D:
                            buffer[num18] = 0;
                            buffer[num18 + 1] = 0;
                            buffer[num18 + 2] = 0;
                            buffer[num18 + 3] = 0;
                        Label_023B:
                            num8 = num8 >> 2;
                        }
                    }
                }
            }
            return buffer;
        }

        public static byte[] DecodeDXT3(byte[] data, int width, int height)
        {
            byte[] buffer = new byte[(width * height) * 4];
            int num = width / 4;
            int num2 = height / 4;
            for (int i = 0; i < num2; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    int num7;
                    int index = ((i * num) + j) * 0x10;
                    ushort[] numArray = new ushort[] { (ushort) ((data[index] << 8) + data[index + 1]), (ushort) ((data[index + 2] << 8) + data[index + 3]), (ushort) ((data[index + 4] << 8) + data[index + 5]), (ushort) ((data[index + 6] << 8) + data[index + 7]) };
                    byte[,] buffer2 = new byte[4, 4];
                    int num6 = 0;
                    while (num6 < 4)
                    {
                        num7 = 0;
                        while (num7 < 4)
                        {
                            buffer2[num7, num6] = (byte) ((numArray[num6] & 15) * 0x10);
                            numArray[num6] = (ushort) (numArray[num6] >> 4);
                            num7++;
                        }
                        num6++;
                    }
                    ushort num8 = (ushort) ((data[index + 8] << 8) + data[index + 9]);
                    ushort num9 = (ushort) ((data[index + 10] << 8) + data[index + 11]);
                    uint num10 = BitConverter.ToUInt32(data, (index + 8) + 4);
                    ushort num11 = 0;
                    ushort num12 = 0;
                    ushort num13 = 0;
                    ushort num14 = 0;
                    ushort num15 = 0;
                    ushort num16 = 0;
                    num11 = (ushort) (8 * (num8 & 0x1f));
                    num12 = (ushort) (4 * ((num8 >> 5) & 0x3f));
                    num13 = (ushort) (8 * ((num8 >> 11) & 0x1f));
                    num14 = (ushort) (8 * (num9 & 0x1f));
                    num15 = (ushort) (4 * ((num9 >> 5) & 0x3f));
                    num16 = (ushort) (8 * ((num9 >> 11) & 0x1f));
                    for (int k = 0; k < 4; k++)
                    {
                        num6 = k ^ 1;
                        for (num7 = 0; num7 < 4; num7++)
                        {
                            int num18 = ((width * ((i * 4) + num6)) * 4) + (((j * 4) + num7) * 4);
                            uint num19 = num10 & 3;
                            buffer[num18 + 3] = buffer2[num7, num6];
                            switch (num19)
                            {
                                case 0:
                                    buffer[num18] = (byte) num11;
                                    buffer[num18 + 1] = (byte) num12;
                                    buffer[num18 + 2] = (byte) num13;
                                    goto Label_02E0;

                                case 1:
                                    buffer[num18] = (byte) num14;
                                    buffer[num18 + 1] = (byte) num15;
                                    buffer[num18 + 2] = (byte) num16;
                                    goto Label_02E0;

                                case 2:
                                    if (num8 <= num9)
                                    {
                                        break;
                                    }
                                    buffer[num18] = (byte) (((2 * num11) + num14) / 3);
                                    buffer[num18 + 1] = (byte) (((2 * num12) + num15) / 3);
                                    buffer[num18 + 2] = (byte) (((2 * num13) + num16) / 3);
                                    goto Label_02E0;

                                case 3:
                                    if (num8 <= num9)
                                    {
                                        goto Label_02C9;
                                    }
                                    buffer[num18] = (byte) ((num11 + (2 * num14)) / 3);
                                    buffer[num18 + 1] = (byte) ((num12 + (2 * num15)) / 3);
                                    buffer[num18 + 2] = (byte) ((num13 + (2 * num16)) / 3);
                                    goto Label_02E0;

                                default:
                                    goto Label_02E0;
                            }
                            buffer[num18] = (byte) ((num11 + num14) / 2);
                            buffer[num18 + 1] = (byte) ((num12 + num15) / 2);
                            buffer[num18 + 2] = (byte) ((num13 + num16) / 2);
                            goto Label_02E0;
                        Label_02C9:
                            buffer[num18] = 0;
                            buffer[num18 + 1] = 0;
                            buffer[num18 + 2] = 0;
                        Label_02E0:
                            num10 = num10 >> 2;
                        }
                    }
                }
            }
            return buffer;
        }

        public static byte[] DecodeDXT5(byte[] data, int width, int height)
        {
            byte[] buffer = new byte[(width * height) * 4];
            int num = width / 4;
            int num2 = height / 4;
            for (int i = 0; i < num2; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    int num8;
                    int index = ((i * num) + j) * 0x10;
                    uint[] numArray = new uint[8];
                    ulong num6 = 0L;
                    numArray[0] = data[index + 1];
                    numArray[1] = data[index];
                    num6 |= data[index + 6];
                    num6 = num6 << 8;
                    num6 |= data[index + 7];
                    num6 = num6 << 8;
                    num6 |= data[index + 4];
                    num6 = num6 << 8;
                    num6 |= data[index + 5];
                    num6 = num6 << 8;
                    num6 |= data[index + 2];
                    num6 = num6 << 8;
                    num6 |= data[index + 3];
                    if (numArray[0] > numArray[1])
                    {
                        numArray[2] = (byte) ((((6 * numArray[0]) + numArray[1]) + 3) / 7);
                        numArray[3] = (byte) ((((5 * numArray[0]) + (2 * numArray[1])) + 3) / 7);
                        numArray[4] = (byte) ((((4 * numArray[0]) + (3 * numArray[1])) + 3) / 7);
                        numArray[5] = (byte) ((((3 * numArray[0]) + (4 * numArray[1])) + 3) / 7);
                        numArray[6] = (byte) ((((2 * numArray[0]) + (5 * numArray[1])) + 3) / 7);
                        numArray[7] = (byte) (((numArray[0] + (6 * numArray[1])) + 3) / 7);
                    }
                    else
                    {
                        numArray[2] = (byte) ((((4 * numArray[0]) + numArray[1]) + 2) / 5);
                        numArray[3] = (byte) ((((3 * numArray[0]) + (2 * numArray[1])) + 2) / 5);
                        numArray[4] = (byte) ((((2 * numArray[0]) + (3 * numArray[1])) + 2) / 5);
                        numArray[5] = (byte) (((numArray[0] + (4 * numArray[1])) + 2) / 5);
                        numArray[6] = 0;
                        numArray[7] = 0xff;
                    }
                    byte[,] buffer2 = new byte[4, 4];
                    int num7 = 0;
                    while (num7 < 4)
                    {
                        num8 = 0;
                        while (num8 < 4)
                        {
                            buffer2[num8, num7] = (byte) numArray[(int) ((IntPtr) (num6 & ((ulong) 7L)))];
                            num6 = num6 >> 3;
                            num8++;
                        }
                        num7++;
                    }
                    ushort num9 = (ushort) ((data[index + 8] << 8) + data[index + 9]);
                    ushort num10 = (ushort) ((data[index + 10] << 8) + data[index + 11]);
                    uint num11 = BitConverter.ToUInt32(data, (index + 8) + 4);
                    ushort num12 = 0;
                    ushort num13 = 0;
                    ushort num14 = 0;
                    ushort num15 = 0;
                    ushort num16 = 0;
                    ushort num17 = 0;
                    num12 = (ushort) (8 * (num9 & 0x1f));
                    num13 = (ushort) (4 * ((num9 >> 5) & 0x3f));
                    num14 = (ushort) (8 * ((num9 >> 11) & 0x1f));
                    num15 = (ushort) (8 * (num10 & 0x1f));
                    num16 = (ushort) (4 * ((num10 >> 5) & 0x3f));
                    num17 = (ushort) (8 * ((num10 >> 11) & 0x1f));
                    for (int k = 0; k < 4; k++)
                    {
                        num8 = k ^ 1;
                        for (num7 = 0; num7 < 4; num7++)
                        {
                            int num19 = ((width * ((i * 4) + num8)) * 4) + (((j * 4) + num7) * 4);
                            uint num20 = num11 & 3;
                            buffer[num19 + 3] = buffer2[num7, num8];
                            switch (num20)
                            {
                                case 0:
                                    buffer[num19] = (byte) num12;
                                    buffer[num19 + 1] = (byte) num13;
                                    buffer[num19 + 2] = (byte) num14;
                                    goto Label_03F9;

                                case 1:
                                    buffer[num19] = (byte) num15;
                                    buffer[num19 + 1] = (byte) num16;
                                    buffer[num19 + 2] = (byte) num17;
                                    goto Label_03F9;

                                case 2:
                                    if (num9 <= num10)
                                    {
                                        break;
                                    }
                                    buffer[num19] = (byte) (((2 * num12) + num15) / 3);
                                    buffer[num19 + 1] = (byte) (((2 * num13) + num16) / 3);
                                    buffer[num19 + 2] = (byte) (((2 * num14) + num17) / 3);
                                    goto Label_03F9;

                                case 3:
                                    if (num9 <= num10)
                                    {
                                        goto Label_03E2;
                                    }
                                    buffer[num19] = (byte) ((num12 + (2 * num15)) / 3);
                                    buffer[num19 + 1] = (byte) ((num13 + (2 * num16)) / 3);
                                    buffer[num19 + 2] = (byte) ((num14 + (2 * num17)) / 3);
                                    goto Label_03F9;

                                default:
                                    goto Label_03F9;
                            }
                            buffer[num19] = (byte) ((num12 + num15) / 2);
                            buffer[num19 + 1] = (byte) ((num13 + num16) / 2);
                            buffer[num19 + 2] = (byte) ((num14 + num17) / 2);
                            goto Label_03F9;
                        Label_03E2:
                            buffer[num19] = 0;
                            buffer[num19 + 1] = 0;
                            buffer[num19 + 2] = 0;
                        Label_03F9:
                            num11 = num11 >> 2;
                        }
                    }
                }
            }
            return buffer;
        }

        public static byte[] DecodeR5G6B5(byte[] data, int width, int height)
        {
            byte[] buffer = new byte[(width * height) * 4];
            for (int i = 0; i < ((width * height) * 2); i += 2)
            {
                short num2 = (short) (data[i] | (data[i + 1] << 8));
                buffer[i * 2] = (byte) (num2 & 0x1f);
                buffer[(i * 2) + 1] = (byte) ((num2 >> 5) & 0x3f);
                buffer[(i * 2) + 2] = (byte) ((num2 >> 11) & 0x1f);
                buffer[(i * 2) + 3] = 0xff;
            }
            return buffer;
        }

        public static byte[] DecodeY8(byte[] data, int width, int height)
        {
            byte[] buffer = new byte[(height * width) * 4];
            for (int i = 0; i < (height * width); i++)
            {
                int index = i * 4;
                buffer[index] = data[i];
                buffer[index + 1] = data[i];
                buffer[index + 2] = data[i];
                buffer[index + 3] = 0xff;
            }
            return buffer;
        }

        private static RGBAColor GradientColors(RGBAColor Color1, RGBAColor Color2)
        {
            RGBAColor color;
            color.R = (byte) (((Color1.R * 2) + Color2.R) / 3);
            color.G = (byte) (((Color1.G * 2) + Color2.G) / 3);
            color.B = (byte) (((Color1.B * 2) + Color2.B) / 3);
            color.A = 0xff;
            return color;
        }

        private static RGBAColor GradientColorsHalf(RGBAColor Color1, RGBAColor Color2)
        {
            RGBAColor color;
            color.R = (byte) ((Color1.R / 2) + (Color2.R / 2));
            color.G = (byte) ((Color1.G / 2) + (Color2.G / 2));
            color.B = (byte) ((Color1.B / 2) + (Color2.B / 2));
            color.A = 0xff;
            return color;
        }

        private static byte[] ModifyLinearTexture(byte[] data, int width, int height, TextureFormat texture, bool toLinear)
        {
            int num;
            int num2;
            int num3;
            byte[] destinationArray = new byte[data.Length];
            switch (texture)
            {
                case TextureFormat.DXT1:
                case TextureFormat.CTX1:
                    num = 4;
                    num2 = 4;
                    num3 = 8;
                    break;

                case TextureFormat.DXT3:
                case TextureFormat.DXT5:
                case TextureFormat.DXN:
                    num = 4;
                    num2 = 4;
                    num3 = 0x10;
                    break;

                case TextureFormat.AY8:
                    num = 4;
                    num2 = 4;
                    num3 = 2;
                    break;

                default:
                    num = 1;
                    num2 = 1;
                    num3 = 2;
                    break;
            }
            int num4 = width / num;
            int num5 = height / num2;
            try
            {
                for (int i = 0; i < num5; i++)
                {
                    for (int j = 0; j < num4; j++)
                    {
                        int offset = (i * num4) + j;
                        int num9 = XGAddress2DTiledX(offset, num4, num3);
                        int num10 = XGAddress2DTiledY(offset, num4, num3);
                        int sourceIndex = ((i * num4) * num3) + (j * num3);
                        int destinationIndex = ((num10 * num4) * num3) + (num9 * num3);
                        if (toLinear)
                        {
                            Array.Copy(data, sourceIndex, destinationArray, destinationIndex, num3);
                        }
                        else
                        {
                            Array.Copy(data, destinationIndex, destinationArray, sourceIndex, num3);
                        }
                    }
                }
            }
            catch
            {
            }
            return destinationArray;
        }

        private static int XGAddress2DTiledX(int Offset, int Width, int TexelPitch)
        {
            int num = (Width + 0x1f) & -32;
            int num2 = (TexelPitch >> 2) + ((TexelPitch >> 1) >> (TexelPitch >> 2));
            int num3 = Offset << num2;
            int num4 = (((num3 & -4096) >> 3) + ((num3 & 0x700) >> 2)) + (num3 & 0x3f);
            int num5 = num4 >> (7 + num2);
            int num6 = (num5 % (num >> 5)) << 2;
            int num7 = (((num4 >> (5 + num2)) & 2) + (num3 >> 6)) & 3;
            int num8 = (num6 + num7) << 3;
            int num9 = ((((num4 >> 1) & -16) + (num4 & 15)) & ((TexelPitch << 3) - 1)) >> num2;
            return (num8 + num9);
        }

        private static int XGAddress2DTiledY(int Offset, int Width, int TexelPitch)
        {
            int num = (Width + 0x1f) & -32;
            int num2 = (TexelPitch >> 2) + ((TexelPitch >> 1) >> (TexelPitch >> 2));
            int num3 = Offset << num2;
            int num4 = (((num3 & -4096) >> 3) + ((num3 & 0x700) >> 2)) + (num3 & 0x3f);
            int num5 = num4 >> (7 + num2);
            int num6 = (num5 / (num >> 5)) << 2;
            int num7 = ((num4 >> (6 + num2)) & 1) + ((num3 & 0x800) >> 10);
            int num8 = (num6 + num7) << 3;
            int num9 = (((num4 & (((TexelPitch << 6) - 1) & -32)) + ((num4 & 15) << 1)) >> (3 + num2)) & -2;
            return ((num8 + num9) + ((num4 & 0x10) >> 4));
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct RGBAColor
        {
            public int R;
            public int G;
            public int B;
            public int A;
        }
    }
}

