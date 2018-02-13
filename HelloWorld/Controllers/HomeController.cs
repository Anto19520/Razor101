using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            var cars = HelloModel.GetCars(); // to get the cars 

            ViewBag.AntoCreateThisValue = "Hello MVC"; // inline 

            return View(cars);
        }
    }
}