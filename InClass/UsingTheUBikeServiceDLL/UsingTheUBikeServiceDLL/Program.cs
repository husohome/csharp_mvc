using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBikeService;

namespace UsingTheUBikeServiceDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            var bikeData = BikeService.GetBikeDataAsync().GetAwaiter().GetResult();
            var filtered = from d in bikeData
                           where d.sarea == "汐止區" && int.Parse(d.sbi) > 1
                           select new { AREA = d.sarea, SBI = d.sbi };

            //bikeData.FindAll(x => x.sarea == "汐止區" && int.Parse(x.sbi) > 0);
            foreach (var entry in filtered)
            {
                Console.WriteLine(entry);
            }
            Console.ReadLine();
        }
    }
}

