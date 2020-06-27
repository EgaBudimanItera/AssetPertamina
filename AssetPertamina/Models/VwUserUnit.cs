using System;
using System.Collections.Generic;

namespace AssetPertamina.Models
{
    public partial class VwUserUnit
    {
        public int IdUser { get; set; }
        public string NamaUser { get; set; }
        public string AksesUser { get; set; }
        public int IdUnit { get; set; }
        public string IsDeleted { get; set; }
        public string NamaUnit { get; set; }
    }
}
