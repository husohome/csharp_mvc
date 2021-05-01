using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apr24_.Models
{
    public class Student
    {
        public Student(string name, string id) {
            this.stuName = name;
            this.stuID = id;
            //this.coursesTaken = coursesTaken; 試試看用viewModel

        }
        public string stuName { get; set; }
        public string stuID { get; set; }

        // public List<Course> coursesTaken { get; set; }
    }
}