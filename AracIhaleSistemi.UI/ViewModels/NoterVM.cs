using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI.ViewModels
{
    public class NoterVM
    {
        public int NoterUcretID { get; set; }
        public DateTime BaslangicTarihi { get; set; }

        public DateTime BitisTarihi { get; set; }

        public decimal NoterUcreti { get; set; }
    }
}
