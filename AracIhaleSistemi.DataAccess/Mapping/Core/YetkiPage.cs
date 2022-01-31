namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("YetkiPage")]
    public partial class YetkiPage:IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public YetkiPage()
        {
            RolDetay = new HashSet<RolDetay>();
        }

        public int YetkiPageID { get; set; }

        [Required]
        public string YetkiPageURL { get; set; }

        public bool AktifMi { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolDetay> RolDetay { get; set; }

        //public virtual Uye Uye { get; set; }

        //public virtual Uye Uye1 { get; set; }
    }
}
