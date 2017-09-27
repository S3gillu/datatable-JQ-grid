using Datatable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;

namespace Datatable.Controllers
{
    public class HomeController : Controller
    {
        WorkerContext context;
        public HomeController()
        {
            context = new WorkerContext();   
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Datatable.Models.Worker model)
        {
            if (string.IsNullOrEmpty(model.Name))
            {
                ModelState.AddModelError("Name", "Name is Required");
            }
            if (string.IsNullOrEmpty(model.Email))
            {
                ModelState.AddModelError("Email", "Email is Required");
            }
            if (string.IsNullOrEmpty(model.Age))
            {
                ModelState.AddModelError("Age", "Age is Required");
            }
            if (string.IsNullOrEmpty(model.StartDate))
            {
                ModelState.AddModelError("StartDate", "StartDate is Required");
            }
            if (string.IsNullOrEmpty(model.Address))
            {
                ModelState.AddModelError("Address", "Address is Required");
            }
            if (ModelState.IsValid)
            {
                ViewBag.Name = model.Name;
                ViewBag.Email = model.Email;
                ViewBag.Age = model.Age;
                ViewBag.StartDate = model.StartDate;
                ViewBag.Address = model.Address;
                ViewBag.Position = model.Position;
            }
            return View(model);
        }

        public ActionResult Create()
        {
            var emp = context.Positions.ToList();
            var viewModel = new WorkerVM
            {
                Employees = new Worker(),
                List = emp

            };

            return View("Create", viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WorkerVM person)
        {

            if (ModelState.IsValid)
            {
                context.Workers.Add(person.Employees);
                context.SaveChanges();
            }

            return RedirectToAction("Index");



        }

        public ActionResult GetData()
        {
            using (WorkerContext db = new WorkerContext())
            {
                var WorkerData = db.Workers.OrderBy(a => a.Name).ToList();
                return Json(new { data = WorkerData }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}