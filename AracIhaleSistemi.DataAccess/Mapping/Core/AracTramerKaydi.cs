namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("AracTramerKaydi")]
    public partial class AracTramerKaydi:IEntity
    {
        public int AracTramerKaydiID { get; set; }

        public int AracID { get; set; }

        public int TramerID { get; set; }

        public int DurumID { get; set; }

        public bool AktifMi { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        //public virtual Arac Arac { get; set; }

        //public virtual Durum Durum { get; set; }

        //public virtual Tramer Tramer { get; set; }

        //public virtual Uye Uye { get; set; }

        //public virtual Uye Uye1 { get; set; }
    }
}
