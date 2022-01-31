using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI.ViewModels
{
    public class UyeAddVM
    {
        public int RolID { get; set; }
        public string AdSoyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Sifre { get; set; }
        public bool AktifMi { get; set; }
    }
}
