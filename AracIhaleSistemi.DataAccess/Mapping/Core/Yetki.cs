namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Yetki")]
    public partial class Yetki:IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Yetki()
        {
            RolDetay = new HashSet<RolDetay>();
        }

        public int YetkiID { get; set; }

        [Required]
        [StringLength(50)]
        public string YetkiAd { get; set; }

        public bool AktifMi { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolDetay> RolDetay { get; set; }

    //    public virtual Uye Uye { get; set; }

    //    public virtual Uye Uye1 { get; set; }
    }
}
