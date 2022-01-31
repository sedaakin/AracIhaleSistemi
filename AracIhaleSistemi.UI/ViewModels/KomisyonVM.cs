using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI.ViewModels
{
    public class KomisyonVM
    {
        public int KomisyonUcretID { get; set; }
        public decimal MinFiyat { get; set; }

        public decimal MaxFiyat { get; set; }

        public decimal KomisyonUcreti { get; set; }

        public DateTime BaslangicTarihi { get; set; }

        public DateTime BitisTarihi { get; set; }
    }
}
