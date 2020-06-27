using System;
using System.Collections.Generic;

namespace AssetPertamina.Models
{
    public partial class VwAset
    {
        public int IdAset { get; set; }
        public string SnAset { get; set; }
        public string Perolehan { get; set; }
        public DateTime? TanggalMasuk { get; set; }
        public int? AsalAset { get; set; }
        public string NamaUnit { get; set; }
        public int? UnitPenerima { get; set; }
        public int? IdAlokasi { get; set; }
        public string KodeAlokasi { get; set; }
        public string NamaAlokasi { get; set; }
        public int? IdKategori { get; set; }
        public string KodeKategori { get; set; }
        public string NamaKategori { get; set; }
        public int? IdSatuan { get; set; }
        public string NamaSatuan { get; set; }
        public string NamaAset { get; set; }
        public long? NilaiPerolehan { get; set; }
        public string PerkiraanUmur { get; set; }
        public string DiterimaOleh { get; set; }
        public string AsalVendor { get; set; }
        public string ButuhPerawatan { get; set; }
        public string IsDeleted { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string UpdatedBy { get; set; }
    }
}
