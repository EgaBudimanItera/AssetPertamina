using System;
using System.Collections.Generic;

namespace AssetPertamina.Models
{
    public partial class TbUser
    {
        public int IdUser { get; set; }
        public string NamaUser { get; set; }
        public string AksesUser { get; set; }
        public int IdUnit { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public string IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedTime { get; set; }

        public virtual TbUnit IdUnitNavigation { get; set; }
    }
}
