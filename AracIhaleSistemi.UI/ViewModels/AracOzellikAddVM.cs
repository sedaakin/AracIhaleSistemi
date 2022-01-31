using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI.ViewModels
{
    public class AracOzellikAddVM:BaseAddVM
    {
        public int? Durum { get; set; }
        public int? BireyselMi { get; set; }
        public int? Marka { get; set; }
        public int? Model { get; set; }
        public int? Versiyon { get; set; }
        public int? GovdeTipi { get; set; }
        public int? VitesTipi { get; set; }
        public int? YakitTipi { get; set; }
        public int? Renk { get; set; }
        public List<int>? OpsiyonelDonanim { get; set; }
        public List<int>? Resim { get; set; }
    }
}
