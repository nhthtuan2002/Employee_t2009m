using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.ServiceEAP;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        static ServiceEAP.Service1Client service1 = new ServiceEAP.Service1Client();
        // GET: Employee
        public ActionResult Index(string search)
        {
            return View(service1.ListEmployee(search));
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Save(Employee employee)
        {
            service1.CreateEmployee(employee);
            return Redirect("Index");
        }
    }
}