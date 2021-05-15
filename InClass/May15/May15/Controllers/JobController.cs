using May15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace May15.Controllers
{
    public class JobController : Controller
    {
        [HttpGet]
        [Route("Job")]
        [Route("Job/index")]
        // GET: Job
        public ActionResult Query()
        {
            ViewData["title"] = "職缺管理";
            return View("Index");
        }

        [HttpPost]
        [Route("Job")]
        [Route("Job/index")]
        [ValidateAntiForgeryToken]
        // GET: Job
        public ActionResult Query(string name, int? pay)
        {
            ViewData["title"] = "職缺管理";
            var queryresult = JobService.Query(name, pay);
            return View("Index", queryresult);
        }

        [HttpGet]
        [Route("Job/Update/{id}")]
        [ValidateAntiForgeryToken]
        // GET: Job
        public ActionResult Update(Guid id)
        {
            var result = JobService.Query(id);
            return View("Edit", result);
        }

        [HttpPost]
        [Route("Job/Update")]
        [ValidateAntiForgeryToken]
        // GET: Job
        public ActionResult Update(JobModel item)
        {
            JobService.Edit(item);
            return View("Index");
        }



        [HttpGet]
        [Route("Job/Add")]
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
        [Route("Job/Add")]
        [ValidateAntiForgeryToken]
        // GET: Job
        public ActionResult Add(JobModel item)
        {
            if (ModelState.IsValid)
            {
                JobService.Add(item);
            }
            else
            {
                return View(item);
            }
            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("Job/View/{id}")]
        // GET: Job
        public ActionResult View(Guid id)
        {
            var item = JobService.Query(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        [HttpGet]
        [Route("Job/Edit/{id}")]
        public ActionResult Edit(Guid id)
        {
            var item = JobService.Query(id);
            if (item == null)
            {

                return HttpNotFound();
            }
            return View(item);
        }

        [HttpGet]
        [Route("Job/Del")]
        // GET: Job
        public ActionResult Del(Guid id)
        {
            JobService.Del(id);
            return RedirectToAction("Index");
        }
    }
}