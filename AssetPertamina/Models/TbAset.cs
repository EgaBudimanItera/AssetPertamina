using System;
using System.Collections.Generic;

namespace AssetPertamina.Models
{
    public partial class TbAset
    {
        public TbAset()
        {
            TbFileUpload = new HashSet<TbFileUpload>();
            TbHistoryAset = new HashSet<TbHistoryAset>();
            TbPenilaianAset = new HashSet<TbPenilaianAset>();
            TbResponFungsi = new HashSet<TbResponFungsi>();
        }

        public int IdAset { get; set; }
        public string SnAset { get; set; }
        public string Perolehan { get; set; }
        public DateTime? TanggalMasuk { get; set; }
        public int? AsalAset { get; set; }
        public int? UnitPenerima { get; set; }
        public int? IdAlokasi { get; set; }
        public int? IdKategori { get; set; }
        public int? IdSatuan { get; set; }
        public string NamaAset { get; set; }
        public long? NilaiPerolehan { get; set; }
        public string PerkiraanUmur { get; set; }
        public string DiterimaOleh { get; set; }
        public string AsalVendor { get; set; }
        public string ButuhPerawatan { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedTime { get; set; }

        public virtual TbUnit AsalAsetNavigation { get; set; }
        public virtual TbAlokasi IdAlokasiNavigation { get; set; }
        public virtual TbKategori IdKategoriNavigation { get; set; }
        public virtual TbSatuan IdSatuanNavigation { get; set; }
        public virtual TbUnit UnitPenerimaNavigation { get; set; }
        public virtual ICollection<TbFileUpload> TbFileUpload { get; set; }
        public virtual ICollection<TbHistoryAset> TbHistoryAset { get; set; }
        public virtual ICollection<TbPenilaianAset> TbPenilaianAset { get; set; }
        public virtual ICollection<TbResponFungsi> TbResponFungsi { get; set; }
    }
}
