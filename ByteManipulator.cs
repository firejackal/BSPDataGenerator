using System;

namespace BSPDataGenerator
{
    public class ByteManipulator
    {
        private int mSize;
        private byte[] mData;

        public ByteManipulator() { }

        public ByteManipulator(int size) { this.Resize(size); }

        public void Resize(int newSize)
        {
            this.mSize = newSize;
            this.mData = new byte[newSize];
        }

        public bool InsertBytes(int start, byte[] data)
        {
            if (this.mSize == 0 || data == null || data.Length == 0) return false;

            for(int x = 0; x < data.Length; x++)
            {
                int newPos = start + x;
                if(newPos >= 0 && newPos < this.mSize)
                {
                    this.mData[newPos] = data[x];
                }
            }

            return true;
        }

        public bool InsertBytes(int start, int end, byte data)
        {
            if (this.mSize == 0) return false;

            for (int x = start; x <= end; x++)
            {
                if (x >= 0 && x < this.mSize)
                {
                    this.mData[x] = data;
                }
            }

            return true;
        }

        public bool InsertText(int start, string text)
        {
            byte[] bytes = GenerateText(text);
            if (bytes == null) return false;
            return this.InsertBytes(start, bytes);
        }

        public bool InsertHex(int start, string hex, int repeatCount = 1)
        {
            byte[] bytes = GenerateHex(hex, repeatCount);
            if (bytes == null) return false;
            return this.InsertBytes(start, bytes);
        }

        public bool SaveToFile(string fileName)
        {
            if(System.IO.File.Exists(fileName))
            {
                try
                {
                    System.IO.File.Delete(fileName);
                } catch(Exception)
                {
                    return false;
                }
            }

            System.IO.FileStream file = System.IO.File.OpenWrite(fileName);
            file.Write(this.mData, 0, this.mSize);
            file.Close();
            return true;
        }

        public static byte[] GenerateText(string text)
        {
            if (string.IsNullOrEmpty(text)) return null;

            //convert text to bytes.
            byte[] data = new byte[text.Length];

            for(int x = 0; x < text.Length; x++)
            {
                try
                {
                    data[x] = Convert.ToByte(text[x]);
                } catch (Exception) {
                    return null;
                }
            }

            return data;
        }

        public static byte[] GenerateHex(string hex, int repeatCount = 1)
        {
            //if (hex == null || hex.Length == 0) return null;
            if (string.IsNullOrEmpty(hex)) return null;

            //if (hex.StartsWith("0x", StringComparison.CurrentCultureIgnoreCase)) {
                //hex = hex.Substring(2);
            if ((hex.Length % 2 != 0) || repeatCount <= 0) return null;

            int chrs = (hex.Length / 2);
            byte[] data = new byte[chrs * repeatCount];

            for (int r = 0; r < repeatCount; r++)
            {
                for (int x = 0; x < chrs; x++)
                {
                    string str = hex.Substring(x * 2, 2);
                    data[(r * chrs) + x] = Convert.ToByte(Convert.ToChar(System.Convert.ToUInt32("0x" + str, 16)));
                }
            }
            return data;
            //}

            //return null;
        }

        public static int HexToDec(string hex)
        {
            return System.Convert.ToInt32(System.Convert.ToUInt32("0x" + hex, 16));
        }

        public static string ReadString(byte[] data, int start)
        {
            if (data == null || data.Length == 0 || start >= data.Length) return null;
            //reads a string until we come across a null character.

            string output = "";
            for(int index = start; index < data.Length; index++)
            {
                if (data[index] == 0) break;
                output += Convert.ToChar(data[index]);
            }

            return output;
        }

        public static byte ReadByte(byte[] data, int start)
        {
            if (data == null || data.Length == 0 || start >= data.Length) return 0;
            return data[start];
        }
    }
}