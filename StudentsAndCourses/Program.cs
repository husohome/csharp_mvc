using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndCourses
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Course("C#", "1");
            var c2 = new Course("Java", "2");
            var c3 = new Course("Pokemon Training", "3");

            var s1 = new Student("AA", "M", 10, new List<Course>() { c1, c2 });
            var s2 = new Student("BB", "F", 20, new List<Course>() { c1, c3 });
            var s3 = new Student("CC", "Non-Bi", 30, new List<Course>() { c2, c3 });

            foreach (var s in new List<Student>() { s1, s2, s3 }) {

                Console.WriteLine($"學員: {s.Name} {s.Age}歲 {s.Gender}");
                Console.WriteLine("修過的課");

                foreach (var c in s.CoursesTaken) {
                    Console.WriteLine($"{c.ID} {c.Name}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
