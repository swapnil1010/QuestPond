using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuestPond.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QuestPond.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
            public HomeController(ILogger<HomeController> logger)
            {
                _logger = logger;
                ViewBag.BaseHref = "/";
            }

            public IActionResult Index()
            {
                
               ViewBag.BaseHref = HttpContext.Request.Path;
                return View();
            }
        }
}
