using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1.View
{
    class Cart
    {
        private Stu _payer;

        public Stu Payer
        {
            get => _payer;
            set
            {
                if (value != null)
                {
                    _payer = value;
                }
            }
        }
        public Cart(Stu payer)
        {
            this.Payer = payer;
        }

        public int GetPrice(bool verbose = true)
        {
            double price = 0;
            if (verbose) Console.WriteLine($"Payer: {this.Payer.Name}");
            foreach (Course c in Payer.Courses)
            {
                price += c.Price;
                if (verbose) Console.WriteLine($"{c.Name}\t${c.Price}");
            }
            if (price >= 20000)
            {
                price *= .8;
                if (verbose) Console.WriteLine("Discount 20% off.");
            }
            else if (price >= 10000)
            {
                price *= .9;
                if (verbose) Console.WriteLine("Discount 10% off.");
            }
            else if (price >= 5000)
            {
                price *= .95;
                if (verbose) Console.WriteLine("Discount 5% off.");
            }
            else
            {
                if (verbose) Console.WriteLine("No Applicable Discount.");
            }
            Console.WriteLine("--------------------------");
            return (int)price;
        }

    }
}
