using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May15Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var jobService = new JobService(
                    new LogServiceFile()
                );

            jobService.run();

            Console.ReadLine();


        }
    }
}
