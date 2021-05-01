using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Course
    {
        private string _name;
        private int _price;
        public static List<Course> allCourses = new List<Course>();

        public Course(string Name, int Price)
        {
            this.Name = Name;
            this.Price = Price;
            allCourses.Add(this);
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length > 100) throw new ArgumentException("Course name must be shorter than 100 characters.");
                _name = value;
            }
        }

        public int Price
        {
            get => _price;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Price must not be negative.");
                _price = value;
            }
        }

        public void AddToStu(Stu stu)
        {
            stu.Courses.Add(this);
        }
    }
}