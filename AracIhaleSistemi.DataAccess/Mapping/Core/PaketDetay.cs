using System;
using System.Collections.Generic;
using System.Text;

namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    public class PaketDetay: IEntity
    {
        public int PaketDetayID { get; set; }

        public int PaketTipID { get; set; }

        public bool Parametre { get; set; }
        public string Tanimlama { get; set; }

        public bool AktifMi { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
