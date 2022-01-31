namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("FavoriAramaDetay")]
    public partial class FavoriAramaDetay:IEntity
    {
        [Key]
        [Column(Order = 0)]
        public int FavoriAramaDetayID { get; set; }

        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FavoriAramaFiltreID { get; set; }

        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FavoriAramaID { get; set; }

        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AracOzellikID { get; set; }

        [Column(Order = 4)]
        public bool AktifMi { get; set; }

        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreatedBy { get; set; }

        [Column(Order = 6)]
        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        //public virtual AracOzellik AracOzellik { get; set; }

        //public virtual FavoriArama FavoriArama { get; set; }

        //public virtual FavoriAramaFiltre FavoriAramaFiltre { get; set; }

        //public virtual Uye Uye { get; set; }

        //public virtual Uye Uye1 { get; set; }
    }
}
