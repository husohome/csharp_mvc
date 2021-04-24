using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Apr24_.Models;

namespace Apr24_.Controllers
{
    [RoutePrefix("course")]
    public class CourseController : Controller
    {
        // GET: Course
        //[HttpGet]
        //[Route("Index")]
        //[Route("")]
        //public ActionResult Index()
        //{
        //    // 假裝從資料庫撈回來一堆資料

        //    ViewBag.course = new List<Course>() { 
        //    //ViewData["courses"] = new List<Course>() {
        //        new Course() { courseID = "0001", courseTitle = "C#"},
        //        new Course() { courseID = "AOXS", courseTitle = "Java"},
        //        new Course() { courseID = "Py21", courseTitle = "Python"},
        //    };

        //    return View();
        //}
        [HttpGet]
        [Route("Index")]
        [Route("")]
        public ActionResult Index() { 
            // 直接把List<Course>傳出去
            return View(
                new List<Course>() { 
                        new Course() { courseID = "0001", courseTitle = "C#"},
                        new Course() { courseID = "AOXS", courseTitle = "Java"},
                        new Course() { courseID = "Py21", courseTitle = "Python"}
                    });

        }


        [HttpGet]
        [Route("edit/{courseID}")]
        public ActionResult Edit(string courseID) {

            ViewBag.courseID = courseID;
            return View();
        }
        [HttpGet]
        [Route("{courseID}")]
        public ActionResult Detail(string courseID) {
            // 試試看用view data
            ViewData["courseID"] = courseID;
            //ViewBag.courseID = courseID;
            return View();
        }

    }
}