using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var emps = new List<Emp>()
            {
                new Emp(1, "Arthur"),
                new Emp(2, "Barbara"),
                new Emp(3, "Cindy"),
                new Emp(4, "Dick")
            };

            var orders = new List<Order>() {
                new Order(1, 2000),
                new Order(3, 4000),
                new Order(4, 12321),
                new Order(2, 123213),
                new Order(1, 12321)
            };

            var query = from e in emps
                        join o in orders
                            on e.ID equals o.ID
                        orderby o.Amount descending
                        select new { ID = e.ID, Name = e.Name, Amount = o.Amount };

            foreach (var q in query) { 
                Console.WriteLine($"{q.ID} {q.Name} {q.Amount}");
            }
            Console.ReadLine();
        }
    }
}
