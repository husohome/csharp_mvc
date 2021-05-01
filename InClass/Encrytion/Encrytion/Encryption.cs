using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encrytion
{
    class Encryption
    {
        private static string _key = "12321asd";
        private static string _iv = "asdae213"; // something like a random seed

        public static string Encrypt(string s) {

            var result = string.Empty;
            var sByte = Encoding.UTF8.GetBytes(s);
            var des = new DESCryptoServiceProvider() {
                // from SymmetricAlgorithm
                Key = Encoding.UTF8.GetBytes(_key),
                IV = Encoding.UTF8.GetBytes(_iv)
            };

            using (var ms = new MemoryStream())
            using (var cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write)) {

                cs.Write(sByte, 0, sByte.Length);
                cs.FlushFinalBlock();
                result = Convert.ToBase64String(ms.ToArray());
            }

                return result;
        }

        public static string Decrypt(string s) {

            var result = string.Empty;
            var sByte = Convert.FromBase64String(s); // reverse "ToBase64String"
            var des = new DESCryptoServiceProvider()
            {
                // from SymmetricAlgorithm
                Key = Encoding.UTF8.GetBytes(_key),
                IV = Encoding.UTF8.GetBytes(_iv)
            };

            using (var ms = new MemoryStream())
            using (var cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write))
            {

                cs.Write(sByte, 0, sByte.Length);
                cs.FlushFinalBlock();
                result = Convert.ToString(ms.ToArray());
            }

            return result;

        }

    }
}
