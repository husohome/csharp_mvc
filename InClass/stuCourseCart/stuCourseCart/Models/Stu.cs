using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Stu
    {
        private string _name;
        private List<Course> _courses;
        public static List<Stu> allStus = new List<Stu>();

        public Stu(string Name)
        {
            this.Name = Name;
            this._courses = new List<Course>();
            allStus.Add(this);
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length == 0 || value.Length >= 100) throw new ArgumentException("Unlikely name. Please check.");
                _name = value;
            }
        }

        public List<Course> Courses
        {
            get => _courses;
        }

        public void BuyCourse(Course c)
        {
            this.Courses.Add(c);
        }
    }
}
