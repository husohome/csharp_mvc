using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace EncryptDecryptFiles
{
    public class Crypto
    {

        private static string _key = "12321asd";
        private static string _iv = "asdae213";

        public static void Encrypt(string src, string target) {

            var des = new DESCryptoServiceProvider() {
                Key = Encoding.UTF8.GetBytes(_key),
                IV = Encoding.UTF8.GetBytes(_iv)
            };

            using (var srcStream = new FileStream(src, FileMode.Open, FileAccess.Read))
            using (var targetStream = new FileStream(target, FileMode.Create, FileAccess.Write)) {

                var dataBytes = new byte[srcStream.Length];
                srcStream.Read(dataBytes, 0, dataBytes.Length);

                using (var cs = new CryptoStream(targetStream, des.CreateEncryptor(), CryptoStreamMode.Write)) {

                    cs.Write(dataBytes, 0, dataBytes.Length);
                    cs.FlushFinalBlock();
                }
            }
        
        }

        public static void Decrypt(string src, string target)
        {

            var des = new DESCryptoServiceProvider()
            {
                Key = Encoding.UTF8.GetBytes(_key),
                IV = Encoding.UTF8.GetBytes(_iv)
            };

            using (var srcStream = new FileStream(src, FileMode.Open, FileAccess.Read))
            using (var targetStream = new FileStream(target, FileMode.Create, FileAccess.Write))
            {

                var dataBytes = new byte[srcStream.Length];
                srcStream.Read(dataBytes, 0, dataBytes.Length);

                using (var cs = new CryptoStream(targetStream, des.CreateDecryptor(), CryptoStreamMode.Write))
                {

                    cs.Write(dataBytes, 0, dataBytes.Length);
                    cs.FlushFinalBlock();
                }
            }

        }

        


    }
}
