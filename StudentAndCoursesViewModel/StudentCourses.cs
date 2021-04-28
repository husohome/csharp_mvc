using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndCoursesViewModel
{
    class StudentCourses
    {
        public Student Student { get; set; }
        public List<Course> CoursesTaken { get; set; }

        public StudentCourses() { }

        public StudentCourses(Student student, List<Course> coursesTaken)
        {
            this.Student = student;
            this.CoursesTaken = coursesTaken;
        }
    }
}
