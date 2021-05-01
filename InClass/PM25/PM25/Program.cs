using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM25
{
    class Program
    {
        static void Main(string[] args)
        {
            var pm25data = PM25Service.GetDataAsync().GetAwaiter().GetResult();
            // use the record text

            // creating a Linq
            var filtered = PM25Service.Filter(pm25data, 60); // the 60 is the threshold for PM2.5

            foreach (var r in filtered) {

                Console.WriteLine(r);
            }
            Console.ReadLine();
        }
    }
}
