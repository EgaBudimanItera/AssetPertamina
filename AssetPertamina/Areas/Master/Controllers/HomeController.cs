using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AssetPertamina.Models;
using AssetPertamina.Areas.Base.Controllers;
using Microsoft.EntityFrameworkCore;

namespace AssetPertamina.Controllers
{
    [Area("Master")]
    public class HomeController : BaseController
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
        
        public async Task<IActionResult> Listunit()
        {
            return View(await _context.TbUnit.Where(i=>i.IsDeleted==1).ToListAsync());
        }
        
    }
}
