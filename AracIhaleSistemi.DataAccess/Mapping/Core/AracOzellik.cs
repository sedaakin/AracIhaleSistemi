namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("AracOzellik")]
    public partial class AracOzellik:IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public AracOzellik()
        //{
        //    AracDetay = new HashSet<AracDetay>();
        //    AracOzellik1 = new HashSet<AracOzellik>();
        //    FavoriAramaDetay = new HashSet<FavoriAramaDetay>();
        //}

        public int AracOzellikID { get; set; }

        public int? UstOzellikID { get; set; }

        [Required]
        [StringLength(50)]
        public string OzellikAdi { get; set; }

        public bool AktifMi { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracDetay> AracDetay { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<AracOzellik> AracOzellik1 { get; set; }

        //public virtual AracOzellik AracOzellik2 { get; set; }

        //public virtual Uye Uye { get; set; }

        //public virtual Uye Uye1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FavoriAramaDetay> FavoriAramaDetay { get; set; }
    }
}
