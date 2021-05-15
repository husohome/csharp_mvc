using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using May15ORM.Models;

namespace May15ORM.Controllers
{
    public class JobsController : Controller
    {
        [HttpGet]
        [Route("Jobs")]
        [Route("Jobs/index")]
        // GET: Job
        public ActionResult Query()
        {
            ViewData["title"] = "職缺管理";
            return View("Index");
        }

        [HttpPost]
        [Route("Jobs")]
        [Route("Jobs/index")]
        [ValidateAntiForgeryToken]
        // GET: Job
        public ActionResult Query(string name, int? pay)
        {
            ViewData["title"] = "職缺管理";
            var queryresult = EFService.Query(name, pay);
            return View("Index", queryresult);
        }

        [HttpGet]
        [Route("Jobs/Update/{id}")]
        [ValidateAntiForgeryToken]
        // GET: Job
        public ActionResult Update(Guid id)
        {
            var result = EFService.Query(id);
            return View("Edit", result);
        }

        [HttpPost]
        [Route("Jobs/Update")]
        [ValidateAntiForgeryToken]
        // GET: Job
        public ActionResult Update(jobs item)
        {
            EFService.Edit(item);
            return View("Index");
        }



        [HttpGet]
        [Route("Jobs/Add")]
        // GET: Job
        public ActionResult Add()
        {
            return View();
        }

        //[HttpPost]
        //[Route("Job/Add")]
        //[ValidateAntiForgeryToken]
        //// GET: Job
        //public ActionResult Add([Bind(Include = "Code,Name,Desc,MinSalary,MaxSalary,JobLocation")] JobModel item)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        JobService.Add(item);
        //    }
        //    else
        //    {
        //        return View(item);
        //    }
        //    return RedirectToAction("index");
        //}

        [HttpPost]
        [Route("Jobs/Add")]
        [ValidateAntiForgeryToken]
        // GET: Job
        public ActionResult Add(jobs item)
        {
            if (ModelState.IsValid)
            {
                EFService.Add(item);
            }
            else
            {
                return View(item);
            }
            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("Jobs/View/{id}")]
        // GET: Job
        public ActionResult View(Guid id)
        {
            var item = EFService.Query(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        [HttpGet]
        [Route("Jobs/Edit/{id}")]
        public ActionResult Edit(Guid id)
        {
            var item = EFService.Query(id);
            if (item == null)
            {

                return HttpNotFound();
            }
            return View(item);
        }

        [HttpGet]
        [Route("Jobs/Del")]
        // GET: Job
        public ActionResult Del(Guid id)
        {
            EFService.Del(id);
            return RedirectToAction("Index");
        }
    }
}