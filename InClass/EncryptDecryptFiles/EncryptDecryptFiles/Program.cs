using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptDecryptFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            // Crypto.Encrypt(@"C:\husohome\c_sharp\EncryptDecryptFiles\test_source.txt", @"C:\husohome\c_sharp\EncryptDecryptFiles\test_source_encrypyed.txt");
            Crypto.Decrypt(@"C:\husohome\c_sharp\EncryptDecryptFiles\test_source_encrypyed.txt", @"C:\husohome\c_sharp\EncryptDecryptFiles\test_source_encrypyed_decrypted.txt");

        }
    }
}
