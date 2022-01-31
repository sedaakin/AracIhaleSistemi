using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI.ViewModels
{
    public class IlanAddVM:BaseAddVM
    {
        public int AracID { get; set; }
        public int Fiyat { get; set; }
        public int Km { get; set; }
        public string IlanBasligi { get; set; }
        public string IlanAciklama { get; set; }
    }
}
