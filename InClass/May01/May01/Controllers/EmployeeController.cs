using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using May01.Models;

namespace May01.Controllers
{
    [RoutePrefix("Employee")]
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [Route("Create")]
        [HttpGet]
        public ActionResult CreateEmployee() {
            return View();
        }

        [Route("Create")]
        [HttpPost]
        public ActionResult CreateEmployee(Employee emp)
        {

            return View();
        }
    }
}