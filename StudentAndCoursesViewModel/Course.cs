using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndCoursesViewModel
{
    class Course
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public Course() { }
        public Course(string name, string ID) {
            this.Name = name;
            this.ID = ID;
        }
    }
}
