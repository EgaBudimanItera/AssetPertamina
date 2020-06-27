using System;
using System.Collections.Generic;

namespace AssetPertamina.Models
{
    public partial class TbFileUpload
    {
        public int IdFile { get; set; }
        public int? IdAset { get; set; }
        public string KetGambar { get; set; }
        public string Path { get; set; }
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
