using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student() { Age = 10, Name="A", Gender = "F" };
            var s2 = new Student() { Age = 20, Name = "AA", Gender ="M" };
            var s3 = new Student() { Age = 30, Name = "AAA", Gender = "Non-bi" };
            var students = new List<Student>() {s1, s2, s3};
            foreach (var s in students) {
                Console.WriteLine($"{s.Name} {s.Age} {s.Gender}"); 
            }
            Console.Read();
            
        }
    }
}
