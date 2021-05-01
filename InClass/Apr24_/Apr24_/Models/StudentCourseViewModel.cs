using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apr24_.Models
{
    public class StudentCourseViewModel
    {
        // 只是用來顯示學生修過那些課的model
        public Student student { get; set; }
        public List<Course> coursesTaken { get; set; }

        public StudentCourseViewModel() { }
        public StudentCourseViewModel(Student student, List<Course> coursesTaken) {

            this.student = student;
            this.coursesTaken = coursesTaken;
        }

    }
}