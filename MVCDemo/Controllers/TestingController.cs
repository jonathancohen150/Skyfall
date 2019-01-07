using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class TestingController : Controller
    {
        public object Test { get; set; }

        // GET: Testing
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ListTesting()
        { 


            Test.Add(new TestingModel { FirstName = "Cap", LastName = "Ducky", Age = 25 });
            Test.Add(new TestingModel { FirstName = "Lyrid", LastName = "Doggy", Age = 22 });
            Test.Add(new TestingModel { FirstName = "Smoke", LastName = "Cat", Age = 27 });

            return View(Test);
        }
    }
}