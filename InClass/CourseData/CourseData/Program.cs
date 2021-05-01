using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseData
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new List<CourseData>() { 
                new CourseData() {Teacher = "Hey", Title ="Python 1", Hours=10 },
                new CourseData() {Teacher = "Jude", Title ="Python 2", Hours=20 },
                new CourseData() {Teacher = "Dont", Title ="C#", Hours=30 },
                new CourseData() {Teacher = "Be", Title ="Java", Hours=40 },
                new CourseData() {Teacher = "Afraid", Title ="DataBase", Hours= 50 }
            };

            var filtered = from c in courses
                        where c.Title.Contains("Python")
                        select new { c.Title, c.Hours };

            foreach (var c in filtered) {
                Console.WriteLine(c.Hours, c.Title);
            }
        }
    }
}
