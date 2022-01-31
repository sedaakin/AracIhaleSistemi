using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI.ViewModels
{
    public class BaseAddVM
    {
        public int ID { get; set; }
        public bool AktifMi { get; set; }
        public string KaydedenKullanici { get; set; }
        public System.DateTime KayitZamani { get; set; }
    }
}
