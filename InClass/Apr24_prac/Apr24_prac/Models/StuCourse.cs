using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apr24_prac.Models
{
    public class StuCourse
    {
        public StuCourse()
        {

        }
        public StuCourse(Student student, List<Course> courses)
        {
            this.student = student;
            this.courses = courses;
        }
        public Student student { get; set; }
        public List<Course> courses { get; set; }
    }
}