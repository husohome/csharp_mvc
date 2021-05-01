using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace May01.Controllers
{
    public class RazorPageController : Controller
    {
        // GET: RazorPage
        public ActionResult Index()
        {
            return View();
        }
    }
}