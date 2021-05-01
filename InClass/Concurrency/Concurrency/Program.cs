using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            //AsyncPrac.Run0();
            //AsyncPrac.Run();
            //AsyncPrac.Run1();
            //AsyncPrac.Run2();
            //Task.Run(() => AsyncPrac.Run2());
            //Task.Run(() => AsyncPrac.Run3());
            //AsyncPrac.Run4();
            Console.WriteLine($"Main thread doing its own job before run() => {DateTime.Now.ToString()}");
            // await AsyncPrac.Run5();
            // await AsyncPrac.MyDownloadAsync();
            var result = AsyncPrac.MyDownloadWithReturnsAsync();
            Console.WriteLine(result.GetAwaiter().GetResult());
            Console.WriteLine($"Main thread doing its own job after run() => {DateTime.Now.ToString()}");
            Console.ReadLine();
        }
    }
}
