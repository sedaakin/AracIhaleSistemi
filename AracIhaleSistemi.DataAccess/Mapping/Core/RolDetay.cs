namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("RolDetay")]
    public partial class RolDetay:IEntity
    {
        public int RolDetayID { get; set; }

        public int RolID { get; set; }

        public int YetkiID { get; set; }

        public int YetkiPageID { get; set; }

        public bool AktifMi { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        //public virtual Rol Rol { get; set; }

        //public virtual Uye Uye { get; set; }

        //public virtual Uye Uye1 { get; set; }

        //public virtual Yetki Yetki { get; set; }

        //public virtual YetkiPage YetkiPage { get; set; }
    }
}
