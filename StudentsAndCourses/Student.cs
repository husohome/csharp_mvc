using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndCourses
{
    class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public List<Course> CoursesTaken { get; set; }

        public Student() { 
        
        }

        public Student(string name, string gender, int age, List<Course> coursesTaken) {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.CoursesTaken = coursesTaken;
        }
    }
}
