using System;
using System.Collections.Generic;

namespace AssetPertamina.Models
{
    public partial class TbResponFungsi
    {
        public TbResponFungsi()
        {
            TbResponAdmin = new HashSet<TbResponAdmin>();
        }

        public int IdResponFungsi { get; set; }
        public int? IdAset { get; set; }
        public string JenisRespon { get; set; }
        public DateTime? TanggalResponFungsi { get; set; }
        public string Alasan { get; set; }
        public string DikirimKe { get; set; }
        public string StatusRespon { get; set; }
        public DateTime? TanggalProses { get; set; }
        public DateTime? TanggalSelesai { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedTime { get; set; }

        public virtual TbAset IdAsetNavigation { get; set; }
        public virtual ICollection<TbResponAdmin> TbResponAdmin { get; set; }
    }
}
