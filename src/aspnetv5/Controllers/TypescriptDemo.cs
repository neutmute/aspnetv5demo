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

        public IActionResult Page1Partial()
        {
            return View();
        }

        public IActionResult Page2Partial()
        {
            return View();
        }
    }
}
