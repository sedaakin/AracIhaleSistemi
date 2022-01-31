namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("LogKayitlari")]
    public partial class LogKayitlari:IEntity
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LogID { get; set; }

        [Column(Order = 1)]
        [StringLength(50)]
        public string Tablo { get; set; }

        [Column(Order = 2)]
        public string EskiVeri { get; set; }


        [Column(Order = 3)]
        public string YeniVeri { get; set; }

        public string MACAdres { get; set; }

        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreatedBy { get; set; }

        [Column(Order = 5)]
        public DateTime CreatedDate { get; set; }

        //public virtual Uye Uye { get; set; }
    }
}
