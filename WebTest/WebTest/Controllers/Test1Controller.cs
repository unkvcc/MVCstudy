using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTest.Controllers
{

    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return this.CustomerName + "|" + this.Address;
        }
    }


    public class Test1Controller : Controller
    {
        // GET: Test1
        public ActionResult Index()
        {
            return View();
        }

        public string Getstring()
        {
            return "Hello nigga";
        }

        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "Customer 1";
            c.Address = "Address1";
            return c;
        }

        [NonAction]
        public string SimpleMethod()
        {
            return "Hi, I am not action method";
        }

        public ActionResult GetView()
        {
            return View("MyView");
        }

    }


}

