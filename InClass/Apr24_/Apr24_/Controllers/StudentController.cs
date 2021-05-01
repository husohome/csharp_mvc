using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Apr24_.Models;

namespace Apr24_.Controllers
{
    [RoutePrefix("student")]
    public class StudentController : Controller
    {
        // GET: Student
        [HttpGet]
        [Route("index")]
        [Route("")]
        public ActionResult Index()
        {
            var s1 = new Student("Ian", "383838");
            var s1Courses = new List<Course>() {
                        new Course() { courseID="asdasd", courseTitle="C#"},
                        new Course() {  courseID="a123", courseTitle="C++"},
                        new Course() {  courseID="3123", courseTitle="C--"},
                    };
            var s2 = new Student("IanClone", "3838388");
            var s2Courses = new List<Course>() {
                        new Course() {  courseID="12321", courseTitle="C++++"},
                        new Course() {  courseID="123", courseTitle="C----"},
                    };
            var s3 = new Student("IanClone2", "3838388");
            var s3Courses = new List<Course>() {
                        new Course() {  courseID="123", courseTitle="CC+"},
                        new Course() {  courseID="12312", courseTitle="CC-"},
                        new Course() {  courseID="1231321", courseTitle="C**"},
                        new Course() {  courseID="asdasd", courseTitle="C//"}
                    };


    

            return View(
                    new List<StudentCourseViewModel>() { 
                        new StudentCourseViewModel(s1, s1Courses), // 故意製造一個null 
                        new StudentCourseViewModel(s2, s2Courses), 
                        new StudentCourseViewModel(s3, s3Courses),
                        new StudentCourseViewModel(null, null)
                    }
                );
        }

    }
}