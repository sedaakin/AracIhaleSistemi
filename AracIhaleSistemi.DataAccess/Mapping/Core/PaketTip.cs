using System;
using System.Collections.Generic;
using System.Text;

namespace AracIhaleSistemi.DataAccess.Mapping.Core
{
    public class PaketTip: IEntity
    {
        public int PaketTipID { get; set; }

        public string PaketTipi { get; set; }

        public bool AktifMi { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
