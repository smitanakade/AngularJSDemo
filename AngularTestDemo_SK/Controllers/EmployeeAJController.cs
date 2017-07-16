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
            var emplist = new List<Emp>
            {
                new Emp {ID=1,FirstName="Tina",LastName="Goa" },
                new Emp {ID=2,FirstName="AJTest",LastName="Test2" },
                new Emp {ID=3,FirstName="Maria",LastName="Janet" },
                new Emp {ID=4,FirstName="Henry",LastName="AU" },
                new Emp {ID=5,FirstName="Sam",LastName="Dont Know" },
                new Emp {ID=6,FirstName="Harry",LastName="Shing" },
            };

            /*Taking record from EF and sending through Json*/

            //tempdbEntities context = new tempdbEntities();
            //var emp_data = context.Employees.Where(e => e.IsActive == 1).ToList();
            return new JsonResult { Data = emplist, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
    }
}