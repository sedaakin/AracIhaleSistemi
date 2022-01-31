using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI.ViewModels
{
    public class AracVM:BaseAddVM
    {
        public int? Yil { get; set; }
        public int? TramerTutari { get; set; }
        public string Durum { get; set; }
        public bool? BireyselMi { get; set; }
        public string? Marka { get; set; }
        public string? Model { get; set; }
        public int? Versiyon { get; set; }
        public int? GovdeTipi { get; set; }
        public int? VitesTipi { get; set; }
        public int? YakitTipi { get; set; }
        public int? Renk { get; set; }
        public List<int>? OpsiyonelDonanim { get; set; }
        public List<int>? Resim { get; set; }
    }
}
