using System;
using System.Collections.Generic;

namespace AssetPertamina.Models
{
    public partial class TbResponAdmin
    {
        public int IdResponAdmin { get; set; }
        public int? IdResponFungsi { get; set; }
        public DateTime? TanggalResponAdmin { get; set; }
        public string JenisRespon { get; set; }
        public string KetRespon { get; set; }
        public long? BiayaPerbaikan { get; set; }
        public string DiterimaOleh { get; set; }

        public virtual TbResponFungsi IdResponFungsiNavigation { get; set; }
    }
}
