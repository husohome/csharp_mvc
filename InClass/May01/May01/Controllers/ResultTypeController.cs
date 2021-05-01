using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace May01.Controllers
{
    [RoutePrefix("ResultType")]
    public class ResultTypeController : Controller
    {
        // GET: ResultType
        [Route("")]
        [Route("index")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("SayHi")]
        public ContentResult SayHi() {

            return Content("嗨嗨嗨", "text/pain");
        }

        [Route("GetPic")]
        public FilePathResult GetPic() {

            var picture = $"~/Imgs/1.png";
            return File(picture, "image/png");
        }

        [Route("RedirectUrl")]
        public RedirectResult RedirectThruURL() {

            return Redirect("/ResultType/RedirectOtherSite/");
        }

        [Route("RedirectOtherSite")]
        public RedirectResult RedirectToOtherSite() {
            return Redirect("https://code.jquery.com/");
        }

        [Route("RedirectAction")]
        public RedirectToRouteResult RedirectAction() {

            return RedirectToAction("RedirectOtherSite","ResultType");
        }
    }
}