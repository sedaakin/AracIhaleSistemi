namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ChatBot")]
    public partial class ChatBot:IEntity
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChatbotID { get; set; }
        [Column(Order = 1)]
        [StringLength(100)]
        public string Soru { get; set; }

        [StringLength(100)]
        public string Cevap { get; set; }

        [Column(Order = 2)]
        public bool AktifMi { get; set; }

        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreatedBy { get; set; }

        [Column(Order = 4)]
        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual Uye Uye { get; set; }

        public virtual Uye Uye1 { get; set; }
    }
}
