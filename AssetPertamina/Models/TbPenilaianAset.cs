using System;
using System.Collections.Generic;

namespace AssetPertamina.Models
{
    public partial class TbPenilaianAset
    {
        public int IdPenilaian { get; set; }
        public int? IdAset { get; set; }
        public DateTime? TanggalPenilaian { get; set; }
        public int? Fisik { get; set; }
        public int? Fungsi { get; set; }
        public int? Kehandalan { get; set; }
        public string NamaPenilai { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedTime { get; set; }

        public virtual TbAset IdAsetNavigation { get; set; }
    }
}
