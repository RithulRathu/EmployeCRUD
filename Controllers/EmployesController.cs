using Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee.Controllers
{
    public class EmployesController : Controller
    {

        private EmployeEntity empDbContext = new EmployeEntity();
        // GET: Employes
        public ActionResult Index()
        {
            List<Employe> emplist = empDbContext.employees.ToList();
            return View(emplist);
        }

        public ActionResult AddEmploye()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmploye(Employe emp)
        {
            if (ModelState.IsValid) {
                empDbContext.employees.Add(emp);
                empDbContext.SaveChanges();
                TempData["AlertMessage"] = "Employe Added Sucessfull...";
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Employe employedata = empDbContext.employees.Find(id);
            return View(employedata);
        }

        [HttpPost]
        public ActionResult Edit(Employe employeupdateddata) {
            Employe existemploye = empDbContext.employees.Find(employeupdateddata.Id);
            if (existemploye != null) {
                existemploye.Name = employeupdateddata.Name;
                existemploye.Phone = employeupdateddata.Phone;
                existemploye.Email = employeupdateddata.Email;
                empDbContext.SaveChanges();
                TempData["AlertMessage"] = "Employe Updated Sucessfull...";
            }
            else
            {
                TempData["AlertMessage"] = "Some Think Went To Wrong...";
            }
            return RedirectToAction("Index");
        }
    }
}