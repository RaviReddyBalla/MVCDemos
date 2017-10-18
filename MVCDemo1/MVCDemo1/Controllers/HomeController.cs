using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo1.Models;

namespace MVCDemo1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.teams = new List<string>
            {
                "Sandbridge",
                "Chicksbeach",
                "PE",
                "Croatan"
            };

            return View();
        }

        public ActionResult AllEmpDetails()
        {
            EmployeeContext employee = new EmployeeContext();
            List<Employee> employees = employee.Employees.ToList();
            return View(employees);
        }

       // [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(FormCollection formcollection)
        //{
        //    EmployeeContext empcon = new EmployeeContext();
        //    Employee emp = new Employee();
        //    emp.Name = formcollection["Name"];
        //    emp.Salaray = Int32.Parse(formcollection["Salaray"]);
        //    empcon.Employees.Add(emp);
        //    empcon.SaveChanges();
        //    return RedirectToAction("AllEmpDetails");
        //}

       // [HttpPost]
      //  [ActionName("Create")]
        public ActionResult Create(Employee emp)
        {
            EmployeeContext empcon = new EmployeeContext();
            //Employee emp = new Employee();
            if (ModelState.IsValid)
            {
                TryUpdateModel(emp);
            }
            empcon.Employees.Add(emp);
            empcon.SaveChanges();
            return RedirectToAction("AllEmpDetails");
        }
        public ActionResult EmpDetails(int id)
        {
            EmployeeContext employee = new EmployeeContext();
            Employee emp1 = employee.Employees.Single(emp => emp.employeeid == id);
            return View(emp1);
        }
        public ActionResult Details()
        {
            Employee emp = new Employee()
            {
                employeeid = 101,
                Name = "Ravi",
                Salaray = 10000
            };

            return View(emp);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}