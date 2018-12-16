using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace mhaetc
{
    class ToolClass
    {
        public static string moocvk = "";
        public static string moocsk = "";
        public static string username = "";
        public static string avatarUrl = "";
        public static string userid = "";

        public static string Base64(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes("str");
            return Convert.ToBase64String(bytes);
        }

        public static string GetLeft(string str, string s)
        {
            string temp = str.Substring(0, str.IndexOf(s));
            return temp;
        }

        public static string GetRight(string str, string s)
        {
            string temp = str.Substring(str.IndexOf(s) + 1, str.Length - str.Substring(0, str.IndexOf(s)).Length - 1);
            return temp;
        }

        public static string Between(string str, string leftstr, string rightstr)
        {
            int i = str.IndexOf(leftstr) + leftstr.Length;
            string temp = str.Substring(i, str.IndexOf(rightstr, i) - i);
            return temp;
        }

        public static string getSign(string str)
        {
            return MD5.encode32(str + "xF3m1m4CrvQd3VsfsEpIf6s0CPWT7sJu");
        }
        public class MD5
        {
            public static string encode16(string String)
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(String)), 4, 8);
                t2 = t2.Replace("-", "");
                return t2;
            }

            public static string encode32(string String)
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(String)));
                t2 = t2.Replace("-", "");
                return t2;
            }
        }
    }
}
