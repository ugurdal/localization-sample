using LocalizationSample.Models;
using LocalizationSample.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizationSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Create()
        {
            return View(new CreateVm());
        }

        [HttpPost]
        public IActionResult Create(CreateVm input)
        {
            return RedirectToAction(nameof(Create));
        }

        public IActionResult Create2()
        {
            return View(new Create2Vm());
        }

        [HttpPost]
        public IActionResult Create(Create2Vm input)
        {
            return RedirectToAction(nameof(Create2));
        }
    }
}
