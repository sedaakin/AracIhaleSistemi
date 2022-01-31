namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Uye")]
    public partial class Uye:IEntity
    {
        public int UyeID { get; set; }
        public int? RolID { get; set; }
        public string? AdSoyad { get; set; }

        public string Email { get; set; }
        public string? Telefon { get; set; }

        public byte[] SifreHash { get; set; }

        public byte[] SifreSalt { get; set; }

        public bool AktifMi { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

    }
}
