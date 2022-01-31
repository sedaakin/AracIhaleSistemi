using System;
using System.Collections.Generic;
using System.Text;

namespace AracIhaleSistemi.DataAccess.DTO
{
    public class AracDetayDTO
    {
        public int AltOzellikID { get; set; }
        public int? UstOzellikID { get; set; }
        public string AltOzellik{ get; set; }
        public string UstOzellik { get; set; }

    }
}
