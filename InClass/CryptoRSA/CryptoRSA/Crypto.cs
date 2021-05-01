using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace CryptoRSA { 

    class Crypto
    {

        public static void CryptoRSA(string s) {

            var rsa = new RSACryptoServiceProvider();
            var publicKey = rsa.ToXmlString(false);
            var privateKey = rsa.ToXmlString(true);

            rsa.FromXmlString(publicKey);
            var encryted = Convert.ToBase64String(rsa.Encrypt(Encoding.UTF8.GetBytes(s), false));

            rsa.FromXmlString(privateKey);
            var decrypted = Encoding.UTF8.GetString(
                    rsa.Decrypt(Convert.FromBase64String(encryted), false));
            Console.WriteLine($"Encrypted: {encryted} , Decrypted: {decrypted}");
        }

        public static void CryptoRASFile(string src, string encryptedFilePath, string target)
        {

            var rsa = new RSACryptoServiceProvider();
            var publicKey = rsa.ToXmlString(false);
            var privateKey = rsa.ToXmlString(true);

            rsa.FromXmlString(publicKey);
            using (var srcStream = new FileStream(encryptedFilePath, FileMode.Open, FileAccess.Read))
            using (var encryptedStream = new FileStream(target, FileMode.Create, FileAccess.Write)) {

                var dataBytes = new byte[srcStream.Length];
                srcStream.Read(dataBytes, 0, dataBytes.Length);

                var encryptedDataBytes = rsa.Encrypt(dataBytes, false);
                encryptedStream.Write(encryptedDataBytes, 0, encryptedDataBytes.Length);

            }

            rsa.FromXmlString(privateKey);
            using (var encryptStream = new FileStream(encryptedFilePath, FileMode.Open, FileAccess.Read))
            using (var decryptStream = new FileStream(target, FileMode.Create, FileAccess.Write)) {
                var dataBytes = new byte[encryptStream.Length];
                encryptStream.Read(dataBytes, 0, dataBytes.Length);

                var decryptDataByteArray = rsa.Decrypt(dataBytes, false);
                decryptStream.Write(decryptDataByteArray, 0, decryptDataByteArray.Length);
            }


        }
    }
}
