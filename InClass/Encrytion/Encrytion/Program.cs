using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrytion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Encryption.Encrypt("hello C#"));
            Console.WriteLine(Encryption.Decrypt("8VXHKTxNXOyGmsOE4y5Maw =="));
            Console.ReadLine();
        }
    }
}
