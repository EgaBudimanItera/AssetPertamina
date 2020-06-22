using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetPertamina.Services
{
    public class BaseServices
    {

        protected Models.asetpertamina _context { get; set; }

        public BaseServices()
        {
            _context = new Models.asetpertamina();
        }

        public BaseServices(Models.asetpertamina context)
        {
            _context = context;
        }
    }
}
