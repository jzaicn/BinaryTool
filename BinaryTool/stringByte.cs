using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Variables
{
    public class stringByte
    {
        //普通字符串转字节
        public static byte[] normalStr2Byte(string value)
        {
            byte[] arr = new byte[value.Length];
            for (int i=0;i<value.Length;i++)
            {
                arr[i] = (byte)value[i];
            }
            return arr;
        }

        //字节转普通字符串
        public static string byte2NormalStr(byte[] value)
        {
            string result = "";
            for (int i = 0; i < value.Length; i++)
            {
                result += (char)value[i];
            }
            return result;
        }

        //把一串字符串转换为byte的集合
        public static List<byte> stringToByte(string value)
        {
            //我们不管规则了。如果写错了一些，我们允许的，只用正则得到有效的十六进制数  
            MatchCollection mc = Regex.Matches(value, @"\b[0-9a-fA-F]+\b");
            List<byte> buf = new List<byte>();//填充到这个临时列表中  

            //依次添加到列表中  
            foreach (Match m in mc)
            {
                buf.Add(byte.Parse(m.Value, System.Globalization.NumberStyles.HexNumber));
            }

            return buf;
        }

        //把一串byte转换为一串字符串
        public static string byteToString(byte[] value)
        {
            StringBuilder builder = new StringBuilder();
            //依次的拼接出16进制字符串  
            foreach (byte b in value)
            {
                builder.Append(b.ToString("X2") + " ");
            }
            return builder.ToString();
        }

        //把一个字符串转换为byte
        public static byte stringTobyteOne(string value)
        {
            List<byte> buf = new List<byte>();//填充到这个临时列表中  
            buf = stringToByte(value);
            return buf[0];
        }

        //把一个byte转换为对应字符
        public static string byteToStringOne(byte value)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(value.ToString("X2"));
            return builder.ToString();
        }
    }
}
