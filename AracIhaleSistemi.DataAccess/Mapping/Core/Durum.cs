namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Durum")]
    public partial class Durum:IEntity
    {
        //public Durum()
        //{
        //    AracDurum = new HashSet<AracDurum>();
        //    AracTramerKaydi = new HashSet<AracTramerKaydi>();
        //    Durum11 = new HashSet<Durum>();
        //    IhaleDurum = new HashSet<IhaleDurum>();
        //    IlanDurum = new HashSet<IlanDurum>();
        //}
        [Key]

        public int DurumID { get; set; }

        public int? UstDurumID { get; set; }

        public string DurumAdi{ get; set; }

        public bool AktifMi { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        //public virtual ICollection<AracDurum> AracDurum { get; set; }

        //public virtual ICollection<AracTramerKaydi> AracTramerKaydi { get; set; }

        ////public virtual ICollection<Durum> Durum11 { get; set; }

        ////public virtual Durum Durum2 { get; set; }

        ////public virtual Uye Uye { get; set; }

        ////public virtual Uye Uye1 { get; set; }

        //public virtual ICollection<IhaleDurum> IhaleDurum { get; set; }

        //public virtual ICollection<IlanDurum> IlanDurum { get; set; }
    }
}
