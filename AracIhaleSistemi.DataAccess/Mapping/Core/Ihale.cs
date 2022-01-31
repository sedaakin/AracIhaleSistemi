namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Ihale")]
    public partial class Ihale:IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ihale()
        {
            IhaleArac = new HashSet<IhaleArac>();
            IhaleDurum = new HashSet<IhaleDurum>();
        }

        public int IhaleID { get; set; }

        public int UyeID { get; set; }

        [Required]
        [StringLength(50)]
        public string IhaleAdi { get; set; }

        public bool BireyselMi { get; set; }

        public DateTime BaslangicTarihiSaati { get; set; }

        public DateTime BitisTarihiSaati { get; set; }

        public bool AktifMi { get; set; }

        public int CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ModifiedDate { get; set; }

        //public virtual Uye Uye { get; set; }

        //public virtual Uye Uye1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IhaleArac> IhaleArac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IhaleDurum> IhaleDurum { get; set; }
    }
}
