using AracIhaleSistemi.DataAccess.Mapping.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.Service.Auth
{
    public interface IAuthRepo
    {
        Uye Register(Uye uye, string sifre);
        Task<Uye> Login(string email, string sifre);
        bool UserExist(string email);
 
    }
}
