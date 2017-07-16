using AngularTestDemo_SK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularTestDemo_SK.Controllers
{
    public class EmployeeAJController : Controller
    {
        // GET: EmployeeAJ
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetEmployees()
        {
            /*Taking record from EF and sending through Json*/

            EmpDBEntities context = new EmpDBEntities();
            var emp_data = context.Employees.Where(e => e.IsActive == 1).ToList();
            return new JsonResult { Data = emp_data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
    }
}