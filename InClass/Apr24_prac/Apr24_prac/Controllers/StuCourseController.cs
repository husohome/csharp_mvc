using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Apr24_prac.Models;

namespace Apr24_prac.Controllers
{
    [RoutePrefix("StuCourse")]
    public class StuCourseController : Controller
    {
        // GET: StuCourse
        [HttpGet]
        [Route("")]
        [Route("index")]
        public ActionResult Index()
        {

            var c1 = new Course("1", "C#");
            var c2 = new Course("2", "Java");
            var c3 = new Course("3", "VBA");

            var s1 = new Student("1", "Halo");
            var s2 = new Student("2", "lalalal");
            var s3 = new Student("3", "Alien");

            var sc1 = new StuCourse(s1, new List<Course>() { c1, c2, c3});
            var sc2 = new StuCourse(s2, new List<Course>() { c2, c3});
            var sc3 = new StuCourse(s3, new List<Course>() { c1, c3});

            return View(new List<StuCourse>() {sc1, sc2, sc3});
        }
    }
}