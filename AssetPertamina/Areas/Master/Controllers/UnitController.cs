using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AssetPertamina.Areas.Base.Controllers;
using AssetPertamina.Services;
using AssetPertamina.Models;

namespace AssetPertamina.Areas.Master.Controllers
{
    [Area("Master")]
    public class UnitController : BaseController
    {
        UnitServices _unitService = new UnitServices();
        public async Task<IActionResult> Index()
        {
            return View(_unitService.getDataUnit());
        }

        public IActionResult InsertData([FromBody] TbUnit model)
        {
            model.IsDeleted = 1;
            string retval =_unitService.InsertDataUnit(model);
            string[] splitstring = retval.Split('|');
            if (splitstring[0] == "S")
            {
                return Json(new { success = true, ResponseMessage = splitstring[1] });
            }
            else
            {
                return Json(new { success = false, ResponseMessage = splitstring[1] });
            }
        }

        public IActionResult UpdateData([FromBody] TbUnit model)
        {
            model.IsDeleted = 1;
            string retval = _unitService.EditDataUnit(model);
            string[] splitstring = retval.Split('|');
            if (splitstring[0] == "S")
            {
                return Json(new { success = true, ResponseMessage = splitstring[1] });
            }
            else
            {
                return Json(new { success = false, ResponseMessage = splitstring[1] });
            }
        }

        public IActionResult DeleteData([FromBody] TbUnit model)
        {
            model.IsDeleted = 0;
            string retval = _unitService.DeleteDataUnit(model.IdUnit);
            string[] splitstring = retval.Split('|');
            if (splitstring[0] == "S")
            {
                return Json(new { success = true, ResponseMessage = splitstring[1] });
            }
            else
            {
                return Json(new { success = false, ResponseMessage = splitstring[1] });
            }
        }
    }
}