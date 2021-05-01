using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apr24_prac.Models
{
    public class Student
    {
        public Student()
        {

        }
        public Student(string id, string name)
        {
            this.id = id;
            this.name = name;
            
        }

        public string id { get; set; }
        public string name { get; set; }
    }
}