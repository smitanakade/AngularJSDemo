using AngularTestDemo_SK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularTestDemo_SK.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           return View();
        }
        public JsonResult GetPesrons()
        {

            /*Taking record from EF and sending through Json*/


            EmpDBEntities context = new EmpDBEntities();
            var emp_data = context.Employees.Where(e => e.IsActive == 1).ToList();
            return new JsonResult { Data = emp_data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };


            return new JsonResult {Data= emp_data, JsonRequestBehavior = JsonRequestBehavior.AllowGet};

        }
       

        public ActionResult Multiselect() 
        {
            return View();
        }
    public JsonResult GetMultiRecord()
    {
        var emplist = new List<Emp>
            {
                new Emp {ID=1,FirstName="Tina"},
                new Emp {ID=2,FirstName="Goa" },
                new Emp {ID=3,FirstName="Maria" },
                new Emp {ID=4,FirstName="Henry" },
                new Emp {ID=5,FirstName="Sam" },
                new Emp {ID=6,FirstName="Harry"},
            };
      

        return new JsonResult { Data = emplist, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

    }
        [HttpPost]
        public JsonResult Savedata(int[] EmpIds)
        {
           return new JsonResult { Data = EmpIds, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}