namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UyeOzellik")]
    public partial class UyeOzellik:IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UyeOzellik()
        {
            UyeDetay = new HashSet<UyeDetay>();
        }

        public int UyeOzellikID { get; set; }

        [Required]
        [StringLength(50)]
        public string UyeOzellikAdi { get; set; }

        public bool AktifMi { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        //public virtual Uye Uye { get; set; }

        //public virtual Uye Uye1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UyeDetay> UyeDetay { get; set; }
    }
}
