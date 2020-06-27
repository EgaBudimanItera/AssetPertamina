using System;
using System.Collections.Generic;

namespace AssetPertamina.Models
{
    public partial class TbKategori
    {
        public TbKategori()
        {
            TbAset = new HashSet<TbAset>();
        }

        public int IdKategori { get; set; }
        public string KodeKategori { get; set; }
        public string NamaKategori { get; set; }
        public string IsDeleted { get; set; }

        public virtual ICollection<TbAset> TbAset { get; set; }
    }
}
