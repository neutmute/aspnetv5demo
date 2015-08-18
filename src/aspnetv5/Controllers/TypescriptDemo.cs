using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace aspnetv5.Controllers
{
    public class TypescriptDemo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MainPage()
        {
            return View();
        }

        public IActionResult SecondPage()
        {
            return View();
        }
    }
}
