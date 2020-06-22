using System;
using System.Collections.Generic;

namespace AssetPertamina.Models
{
    public partial class TbUser
    {
        public Guid IdUser { get; set; }
        public string NamaUser { get; set; }
        public string AksesUser { get; set; }
        public Guid? UnitUser { get; set; }
    }
}
