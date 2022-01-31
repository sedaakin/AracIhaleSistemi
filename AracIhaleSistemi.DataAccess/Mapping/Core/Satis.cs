namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Satis:IEntity
    {
        public int SatisID { get; set; }

        public int IlanID { get; set; }

        public int AliciUyeID { get; set; }

        public bool OnayDurum { get; set; }

        public DateTime SatisTarih { get; set; }

        public bool AktifMi { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        //public virtual Ilan Ilan { get; set; }

        //public virtual Uye Uye { get; set; }

        //public virtual Uye Uye1 { get; set; }

        //public virtual Uye Uye2 { get; set; }
    }
}
