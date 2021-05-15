using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using May01.Models;

namespace May01.Controllers
{
    public class ValidationDataController : Controller
    {
        // GET: ValidationData
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ValidationMessage() {
            return View();
        }

        [HttpPost]
        public ActionResult ValidationMessage(Course course)
        {
            if (ModelState.IsValid) {

                // do something if validation passed
                return Content("驗證成功");
            }

            return View();
        }

    }
}