using System;
using System.Collections.Generic;
using System.Linq;
using AssetPertamina.Models;
using Microsoft.AspNetCore;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AssetPertamina.Services
{
    public class UnitServices :BaseServices
    {

        public Task<List<TbUnit>> getDataUnit()
        {
            var hasil = _context.TbUnit.Where(i => i.IsDeleted == 1).ToListAsync();
            return hasil;
        }
    }
}
