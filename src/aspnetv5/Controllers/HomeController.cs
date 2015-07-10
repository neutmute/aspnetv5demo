using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using NLog;
using TagHelperDemo.Models;
using Common.Logging;
using Microsoft.AspNet.Hosting;

namespace TagHelperDemo.Controllers
{
    public class HomeController : Controller
    {
        IHostingEnvironment _environment;
        Logger _nlog = NLog.LogManager.GetCurrentClassLogger();
        ILog _commonLog = Common.Logging.LogManager.GetLogger<HomeController>();

        public HomeController(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        public IActionResult Index()
        {
            _nlog.Info("This is a log direct to nLog");
            _commonLog.Info("This is a log to common.logging");
            var model = new HomeModel();
            model.EnvironmentName = _environment.EnvironmentName;
            return View(model);
        }

        public IActionResult ThrowException()
        {
            throw new DivideByZeroException("This is an exception handling test");
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
