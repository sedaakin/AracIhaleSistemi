namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("IlanDurum")]
    public partial class IlanDurum:IEntity
    {
        public int IlanDurumID { get; set; }

        public int IlanID { get; set; }

        public int DurumID { get; set; }

        public int AdminUyeID { get; set; }

        public bool AktifMi { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        //public virtual Durum Durum { get; set; }

        //public virtual Ilan Ilan { get; set; }

        //public virtual Uye Uye { get; set; }

        //public virtual Uye Uye1 { get; set; }

        //public virtual Uye Uye2 { get; set; }
    }
}
