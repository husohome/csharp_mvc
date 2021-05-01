using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace May01.Controllers
{
    [RoutePrefix("PassData")]
    public class PassDataController : Controller
    {
        // GET: PassData
        [HttpGet]
        [Route("")]
        [Route("index")]
        public ActionResult Index()
        {
            // 如果確定要傳的是 view reuslt 可以改回傳 ViewResult類別 (基底的parent class 是ActionResult)

            // 利用 TempData傳遞資料
            TempData["ErrorMessage"] = "反正出錯了";
            TempData["Time"] = DateTime.Now.ToLongTimeString();

            return RedirectToAction("ErrorMessage", "ErrorHandler");
        }
    }
}