using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JQueryDataTableInMVC.Models;

namespace JQueryDataTableInMVC.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetList()
        {
            //using (DBModels db = new DBModels())
            //{
            //    var empList = db.Employees.ToList<Employee>();
            //    return Json(new { data = empList }, JsonRequestBehavior.AllowGet);
            //}

            var employeeList = PopulateEmployeeList();

            return Json(new { data = employeeList }, JsonRequestBehavior.AllowGet);
        }


        private IList<Employee> PopulateEmployeeList()
        {
            var employees = new List<Employee>
            {
                new Employee { Name = "Jamy", Position = "Salary", Office = "London", Age = 31 },
                new Employee { Name = "Carol", Position = "Chief officer", Office = "London", Age = 31 },
                new Employee { Name = "Mary", Position = "Manager", Office = "Paris", Age = 31 },
                new Employee { Name = "Jimy", Position = "Salary", Office = "London", Age = 31 },
                new Employee { Name = "Patrik", Position = "Salary", Office = "London", Age = 31 },
                new Employee { Name = "Obama", Position = "Salary", Office = "London", Age = 31 },
                new Employee { Name = "Karl", Position = "Salary", Office = "London", Age = 31 }
            };


            return employees;
        }
    }
}