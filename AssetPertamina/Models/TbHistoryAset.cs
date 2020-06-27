using System;
using System.Collections.Generic;

namespace AssetPertamina.Models
{
    public partial class TbHistoryAset
    {
        public int IdHistoryAset { get; set; }
        public int? IdAset { get; set; }
        public DateTime? Tanggal { get; set; }
        public string AsalAset { get; set; }
        public string KetKejadian { get; set; }
        public string PenerimaAset { get; set; }
        public string Vendor { get; set; }
        public string Alokasi { get; set; }
        public string Kategori { get; set; }
        public int? Fungsi { get; set; }
        public int? Kehandalan { get; set; }
        public int? Fisik { get; set; }
        public string Penilai { get; set; }

        public virtual TbAset IdAsetNavigation { get; set; }
    }
}
