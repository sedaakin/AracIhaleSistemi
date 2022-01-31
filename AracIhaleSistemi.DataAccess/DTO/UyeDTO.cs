using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhaleSistemi.DataAccess.DTO
{
    public class UyeDTO:BaseDTO
    {
        public string AdSoyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Sifre { get; set; }
        public string RolAdi { get; set; }
        public int? RolID { get; set; }
    }
}
