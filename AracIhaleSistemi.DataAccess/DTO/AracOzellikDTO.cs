using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhaleSistemi.DataAccess.DTO
{
    public class AracOzellikDTO:BaseDTO
    {
        public int? UstOzellikID { get; set; }
        public string OzellikAdi { get; set; }
    }
}
