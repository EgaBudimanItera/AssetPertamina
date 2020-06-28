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

        public List<TbUnit> getDataUnit()
        {
            var hasil = _context.TbUnit.Where(i => i.IsDeleted == 1).ToList();
            return hasil;
        }

        public string InsertDataUnit(TbUnit model)
        {
            string retval = "";
            try
            {
                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    _context.TbUnit.Add(model);
                    _context.SaveChanges();
                    dbContextTransaction.Commit();

                    retval = "S|Sukses";
                }
            }
            catch(Exception e)
            {
                retval = "E|" + e.Message;
            }
            return retval;
        }
        public string EditDataUnit(TbUnit model)
        {
            string retval = "";
            try
            {
                _context.Update(model);
                _context.SaveChanges();

                retval = "S|Sukses";
            }
            catch (Exception e)
            {
                retval = "E|" + e.Message;
            }
            return retval;
        }

        public string DeleteDataUnit(int id)
        {
            string retval = "";
            try
            {
                var unit = _context.TbUnit.Find(id);
                unit.IsDeleted = 0;

                _context.SaveChanges();

                retval = "S|Sukses";
            }
            catch (Exception e)
            {
                retval = "E|" + e.Message;
            }
            return retval;
        }
    }
}
