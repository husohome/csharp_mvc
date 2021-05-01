using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Apr24_.Models;

namespace Apr24_.Controllers
{
    [RoutePrefix("Login")] //這是因為屬性路由啟動了，這個意思是前綴用 Login/則可以跳用這個Controller Class底下的action methods
    public class LoginController : Controller
    {

        // GET: Login
        [HttpGet] // 這個是標籤，表示這個action方法只會去管get請求
        [Route()] // Login/ 可以進來
        [Route("index")] // login/index 也可以進來
        public ActionResult Index()
        {
            return View();
        }

        //       [HttpPost] // 這個是標籤，表示這個action方法只會去管post請求
        //public ActionResult Verify(FormCollection f) {
        //
        //           ViewBag.uid = f["uid"]; // 把表單傳回來的東西掛在ViewBag物件，丟給view
        //          ViewBag.pwd = f["pwd"]; // 表單用的key是表單物件的name屬性，不是id屬性
        //
        //           return View();
        //      }

        //[HttpPost] // 另外一種把資料從view拿回來的方法; 底層是FormCollection
        //public ActionResult Verify(string uid, string pwd) {
        //    // 框架自動去對應html表單上面input的name屬性以及Action method的參數名稱，必須對得到
        //    ViewBag.uid = uid; 
        //    ViewBag.pwd = pwd;
        //    return View();
        //}

        [Route("Auth")] // 用login/auth 來拿
        [HttpPost]
        public ActionResult Verify(LoginModel lm) {
            //ViewBag.uid = lm.uid;
            //ViewBag.pwd = lm.pwd;
            ViewBag.loginStatus = AuthServices.Verify(lm);

            return View();
        
        }
    }
}