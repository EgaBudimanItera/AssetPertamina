using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AssetPertamina.Areas.Base.Controllers
{
    public class BaseController : Controller
    {
        protected Models.asetpertamina _context { get; set; }

        public BaseController()
        {
            _context = new Models.asetpertamina();
        }

        public BaseController(Models.asetpertamina context)
        {
            _context = context;
        }
    }
}