using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            var bikeData = BikeService.GetBikeDataAsync();
            // need to use .GetAwaiter().GetResult() to get the returned values from Task<T>
            foreach (var entry in bikeData.GetAwaiter().GetResult()) {
                Console.WriteLine(entry);
               // Console.WriteLine($"{entry.sno} {entry.sna} {entry.sarea} ");
            }
            Console.ReadLine();
        }
    }
}
