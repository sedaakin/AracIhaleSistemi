using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI.ViewModels
{
    public class PaketDetayAddVM
    {
        public int PaketDetayID { get; set; }

        public int PaketTipID { get; set; }

        public bool Parametre { get; set; }
        public string Tanimlama { get; set; }
    }
}
