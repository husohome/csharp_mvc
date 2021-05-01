using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Crypto.EncryptAES("Hello C#!"));
            Console.ReadLine();
            
        }
    }
}
