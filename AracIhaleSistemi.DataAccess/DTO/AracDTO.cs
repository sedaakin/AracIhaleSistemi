using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhaleSistemi.DataAccess.DTO
{
    public class AracDTO:BaseDTO
    {
        public string? Durum { get; set; }
        public string? BireyselMi { get; set; }
        public string? Marka { get; set; }
        public string? Model { get; set; }
        public string? Versiyon { get; set; }
        public string? GovdeTipi { get; set; }
        public string? VitesTipi { get; set; }
        public string? YakitTipi { get; set; }
        public string? Renk { get; set; }
        public List<string>? OpsiyonelDonanim { get; set; }
        public List<string>? Resim { get; set; }
    }
}
