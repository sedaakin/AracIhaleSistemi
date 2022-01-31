namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("EkspertizMerkezi")]
    public partial class EkspertizMerkezi:IEntity
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EkspertizMerkeziID { get; set; }

        [Column(Order = 1)]
        [StringLength(50)]
        public string EkspertizMerkeziAdi { get; set; }

        [Column(Order = 2)]
        public string AcikAdres { get; set; }

        [Column(Order = 3)]
        public bool AktifMi { get; set; }

        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreatedBy { get; set; }

        [Column(Order = 5)]
        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        //public virtual Uye Uye { get; set; }

        //public virtual Uye Uye1 { get; set; }
    }
}
