using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AssetPertamina.Areas.Base.Controllers
{
    [Area("Base")]
    public class AuthenticationController : Controller
    {
        [Route("Login")]
        public IActionResult Index()
        {
            return View();
        }

    }
}