using System;
using System.Collections.Generic;

namespace AssetPertamina.Models
{
    public partial class TbUnit
    {
        public TbUnit()
        {
            TbAsetAsalAsetNavigation = new HashSet<TbAset>();
            TbAsetUnitPenerimaNavigation = new HashSet<TbAset>();
            TbUser = new HashSet<TbUser>();
        }

        public int IdUnit { get; set; }
        public string NamaUnit { get; set; }
        public int IsDeleted { get; set; }

        public virtual ICollection<TbAset> TbAsetAsalAsetNavigation { get; set; }
        public virtual ICollection<TbAset> TbAsetUnitPenerimaNavigation { get; set; }
        public virtual ICollection<TbUser> TbUser { get; set; }
    }
}
