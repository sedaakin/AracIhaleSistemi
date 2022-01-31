namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Arac")]
    public partial class Arac:IEntity
    {
        public int AracID { get; set; }
        public decimal TramerTutari { get; set; }
        public decimal Fiyat { get; set; }
        public int Km { get; set; }
        public int Yil { get; set; }

        public bool AktifMi { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }


    }
}
