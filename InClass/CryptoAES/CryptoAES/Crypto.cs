using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace CryptoAES
{
    class Crypto
    {
        private static string _key = "abcdefgh";
        private static string _iv = "87513452";
        private static SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();



        public static string EncryptAES(string s) {

            var toEncrypt = Encoding.UTF8.GetBytes(s);
            var result = string.Empty;

            var md5 = new MD5CryptoServiceProvider();
            var sha256 = new SHA256CryptoServiceProvider();

            var aes = new AesCryptoServiceProvider() { 
                Key = sha256.ComputeHash(Encoding.UTF8.GetBytes(_key)),
                IV = md5.ComputeHash(Encoding.UTF8.GetBytes(_iv))
            };


            using (var ms = new MemoryStream())
            using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write)) {

                cs.Write(toEncrypt, 0, toEncrypt.Length);
                cs.FlushFinalBlock();
                result = Encoding.UTF8.GetString(ms.ToArray());
                    
                    //Convert.ToBase64String(ms.ToArray());
            }

            return result;
        }
    }
}
