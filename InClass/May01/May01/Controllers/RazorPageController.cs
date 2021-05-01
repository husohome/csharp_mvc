using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using May01.Models;

namespace May01.Controllers
{
    [RoutePrefix("RazorPage")]
    public class RazorPageController : Controller
    {
        // GET: RazorPage
        [Route("")]
        [Route("index")]
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ShowCourseData() {
            // using helper function to disaply in view later
            //var courses = new List<Course>() {
            //     new Course("ABC-123", "C# MVC", "asdasd@asdasds.com"),
            //     new Course("DEF-143", "C-- MVC", "asd2@asdasds.com"),
            //     new Course("DEA-213", "C** MVC", "asas31dasd@asdasds.com")
            //};
            return View(new Course("ABC-123", "C# MVC", "asdasd@asdasds.com"));
        }
    }
}