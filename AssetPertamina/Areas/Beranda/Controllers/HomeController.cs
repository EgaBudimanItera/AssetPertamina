using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AssetPertamina.Models;

using Microsoft.EntityFrameworkCore;
using AssetPertamina.Areas.Base.Controllers;
using AssetPertamina.Services;

namespace AssetPertamina.Controllers
{
    [Area("Beranda")]
    public class HomeController : BaseController
    {
       
        private readonly ILogger<HomeController> _logger;
        UnitServices _unitService = new UnitServices();

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
        
        
    }
}
