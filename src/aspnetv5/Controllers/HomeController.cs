using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using NLog;
using TagHelperDemo.Models;
using Common.Logging;

namespace TagHelperDemo.Controllers
{
    public class HomeController : Controller
    {
        Logger _nlog = NLog.LogManager.GetCurrentClassLogger();
        ILog _commonLog = Common.Logging.LogManager.GetLogger<HomeController>();

        public IActionResult Index()
        {
            _nlog.Info("this is nLog");
            _commonLog.Info("This is a common log");
            var model = new HomeModel();
            return View(model);
        }
        
        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
