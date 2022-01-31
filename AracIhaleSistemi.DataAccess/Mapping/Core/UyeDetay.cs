namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UyeDetay")]
    public partial class UyeDetay:IEntity
    {
        public int UyeDetayID { get; set; }

        public int UyeID { get; set; }

        public int UyeOzellikID { get; set; }

        [Required]
        [StringLength(50)]
        public string UyeDetayIcerik { get; set; }

        public bool AktifMi { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        //public virtual Uye Uye { get; set; }

        //public virtual Uye Uye1 { get; set; }

        //public virtual Uye Uye2 { get; set; }

        //public virtual UyeOzellik UyeOzellik { get; set; }
    }
}
