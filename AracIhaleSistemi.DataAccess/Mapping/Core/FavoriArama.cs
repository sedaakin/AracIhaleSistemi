namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("FavoriArama")]
    public partial class FavoriArama:IEntity
    {
        public FavoriArama()
        {
            FavoriAramaDetay = new HashSet<FavoriAramaDetay>();
        }

        public int FavoriAramaID { get; set; }

        public int UyeID { get; set; }

        public bool AktifMi { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        //public virtual Uye Uye { get; set; }

        //public virtual Uye Uye1 { get; set; }

        //public virtual Uye Uye2 { get; set; }

        public virtual ICollection<FavoriAramaDetay> FavoriAramaDetay { get; set; }
    }
}
