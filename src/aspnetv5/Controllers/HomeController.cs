using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using NLog;
using TagHelperDemo.Models;

namespace TagHelperDemo.Controllers
{
    public class HomeController : Controller
    {
        Logger _nlog = LogManager.GetCurrentClassLogger();
        public IActionResult Index()
        {
            _nlog.Info("Foobar");
            var model = new HomeModel();
            return View(model);
        }
        
        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
