using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.Service.DTOs
{
    public class UyeDTO
    {
        public int UyeID { get; set; }
        public byte[] SifreSalt { get; set; }
        public byte[] SifreHash { get; set; }
        public string Email { get; set; }
    }
}
