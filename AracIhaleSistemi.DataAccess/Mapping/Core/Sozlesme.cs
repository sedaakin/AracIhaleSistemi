namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Sozlesme")]
    public partial class Sozlesme:IEntity
    {
        public int SozlesmeID { get; set; }

        [Required]
        public string SozlesmeUrl { get; set; }

        public DateTime SozlesmeTarih { get; set; }

        public bool UyelikSozlesmesiMi { get; set; }

        public bool AktifMi { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        //public virtual Uye Uye { get; set; }

        //public virtual Uye Uye1 { get; set; }
    }
}
