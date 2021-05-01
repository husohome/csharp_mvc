using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using ConsoleApp1.View;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Stu s1 = new Stu("Mr. MeeSeeks");
            Course c1 = new Course("C#", 9990);
            Course c2 = new Course("Java", 12800);
            Course c3 = new Course("Java II", 12300);
            Cart cart = new Cart(s1);

            s1.BuyCourse(c1);
            s1.BuyCourse(c2);
            s1.BuyCourse(c3);
            Console.WriteLine(
               $" Total is ${cart.GetPrice()}"
            );
            Console.ReadLine();
        }
    }
}