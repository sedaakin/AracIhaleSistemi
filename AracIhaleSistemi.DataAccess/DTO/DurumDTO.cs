using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhaleSistemi.DataAccess.DTO
{
    public class DurumDTO:BaseDTO
    {
        public int? UstDurumID { get; set; }
        public string DurumAdi { get; set; }
    }
}
