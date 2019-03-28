using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace minghuaetc
{
    class Client
    {
        internal static string url = "http://api.mooc.minghuaetc.com/v1";
        internal static string moocsk = "";
        internal static string moocvk = "";
        internal static string stuName = "";

        public static string getPwdEncrypt(string aStrString)
        {
            try
            {
                var des = new TripleDESCryptoServiceProvider
                {
                    Key = Convert.FromBase64String("DrZPGgL9WHkZrVQ0DT2bASoZE0Z8oc4s"),
                    Mode = CipherMode.ECB
                };
                var desEncrypt = des.CreateEncryptor();
                byte[] buffer = Encoding.UTF8.GetBytes(aStrString);
                return Convert.ToBase64String(desEncrypt.TransformFinalBlock(buffer, 0, buffer.Length));
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public static string getSign(string str)
        {
            string pwd = string.Empty;

            //实例化一个md5对像
            MD5 md5 = MD5.Create();

            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(str + "xF3m1m4CrvQd3VsfsEpIf6s0CPWT7sJu"));

            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                pwd = pwd + s[i].ToString("x2");
            }

            return pwd;
        }
    }
}
