using System;
using System.Collections.Generic;

namespace AssetPertamina.Models
{
    public partial class TbAlokasi
    {
        public TbAlokasi()
        {
            TbAset = new HashSet<TbAset>();
        }

        public int IdAlokasi { get; set; }
        public string KodeAlokasi { get; set; }
        public string NamaAlokasi { get; set; }
        public string IsDeleted { get; set; }

        public virtual ICollection<TbAset> TbAset { get; set; }
    }
}
