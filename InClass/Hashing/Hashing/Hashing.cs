using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    class Hashing
    {

        private static string _key = "blaj asda123";
        public static string RunHash(string s) {

            var result = string.Empty;
            var secretKey = Encoding.UTF8.GetBytes(_key);
            var contentData = Encoding.UTF8.GetBytes(s);

            using (var hashalgorithm = new HMACSHA256(secretKey)) {
                using (var bufStream = new MemoryStream()) {
                    var hashData = hashalgorithm.ComputeHash(bufStream);
                    return Encoding.UTF8.GetString(hashData);
                }
                    
            }

        }
    }
}
