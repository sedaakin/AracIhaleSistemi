using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI.ViewModels
{
    public class AracAddVM
    {
        public int Yil { get; set; }
        public int TramerTutari { get; set; }
        public decimal Fiyat { get; set; }
        public int Km { get; set; }
        public AracDetayAddVM AracDetayAddVM { get; set; }
        public AracDurumAddVM AracDurumAddVM { get; set; }
    }
}
