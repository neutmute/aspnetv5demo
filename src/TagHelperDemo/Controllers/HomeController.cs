using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using TagHelperDemo.Models;

namespace TagHelperDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Organisation
            {
                Name = "Microsoft Corp",
                StreetAddress = "One Microsoft Way",
                AddressLocality = "Redmond",
                AddressRegion = "WA",
                PostalCode = "98052-6399"
            };
            return View(model);
        }
        
        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
