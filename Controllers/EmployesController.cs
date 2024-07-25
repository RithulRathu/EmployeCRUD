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
            return View();
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
    }
}