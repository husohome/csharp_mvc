using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace May01.Controllers
{
    [RoutePrefix("Error")]
    public class ErrorHandler : Controller
    {
        // GET: ErrorHandler
        [HttpGet]
        [Route("")]
        [Route("index")]
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        [Route("ErrorMessage")]
        public ActionResult ErrorMessage() {

            return View();
        }
    }
}