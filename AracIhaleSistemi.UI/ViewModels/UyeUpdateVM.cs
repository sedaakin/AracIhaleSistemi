﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI.ViewModels
{
    public class UyeUpdateVM
    {
        public int UyeID { get; set; }
        public bool AktifMi { get; set; }
        public string AdSoyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public int RolID { get; set; }
    }
}
