using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhaleSistemi.DataAccess.DTO
{
    public class BaseDTO
    {
        public int ID { get; set; }
        public bool AktifMi { get; set; }
        public string KaydedenKullanici { get; set; }
        public System.DateTime KayitZamani { get; set; }
        
    }
}
