using System;
using System.Collections.Generic;

namespace AssetPertamina.Models
{
    public partial class TbSatuan
    {
        public TbSatuan()
        {
            TbAset = new HashSet<TbAset>();
        }

        public int IdSatuan { get; set; }
        public string NamaSatuan { get; set; }
        public string IsDeleted { get; set; }

        public virtual ICollection<TbAset> TbAset { get; set; }
    }
}
