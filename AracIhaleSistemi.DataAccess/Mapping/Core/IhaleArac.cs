namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("IhaleArac")]
    public partial class IhaleArac:IEntity
    {
        public int IhaleAracID { get; set; }

        public int IhaleID { get; set; }

        public int AracID { get; set; }

        public decimal BaslangicFiyat { get; set; }

        public decimal MinFiyat { get; set; }

        public bool AktifMi { get; set; }

        public int CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ModifiedDate { get; set; }

        //public virtual Arac Arac { get; set; }

        //public virtual Ihale Ihale { get; set; }

        //public virtual Uye Uye { get; set; }

        //public virtual Uye Uye1 { get; set; }
    }
}
