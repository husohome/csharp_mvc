using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndCoursesViewModel
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student("AAA", 10, "M");
            var s2 = new Student("BBB", 20, "F");
            var s3 = new Student("CCC", 30, "Non-bi");
            var c1 = new Course("C#", "1");
            var c2 = new Course("Java", "2");
            var c3 = new Course("Pokemon Training", "3");
            var sc1 = new StudentCourses(s1, new List<Course>() { c1, c2 });
            var sc2 = new StudentCourses(s2, new List<Course>() { c1, c3 });
            var sc3 = new StudentCourses(s3, new List<Course>() { c2, c3 });

            foreach (var sc in new List<StudentCourses>() { sc1, sc2, sc3}) {

                Console.WriteLine($"學員:{sc.Student.Name} {sc.Student.Age}歲 {sc.Student.Gender}");
                Console.WriteLine("修過的課: ");
                foreach (var c in sc.CoursesTaken) {
                    Console.WriteLine($"{c.ID} {c.Name}" );
                }
                Console.WriteLine();
            }

            Console.Read();

        }
    }
}
