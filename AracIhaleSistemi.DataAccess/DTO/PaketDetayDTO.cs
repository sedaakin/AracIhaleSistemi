using System;
using System.Collections.Generic;
using System.Text;

namespace AracIhaleSistemi.DataAccess.DTO
{
    public class PaketDetayDTO
    {
        public int PaketDetayID { get; set; }

        public string PaketTip { get; set; }

        public string Parametre { get; set; }
        public string Tanimlama { get; set; }
    }
}
