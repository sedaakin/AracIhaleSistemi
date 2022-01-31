using AracIhaleSistemi.DataAccess.DTO;
using AracIhaleSistemi.DataAccess.Mapping.Core;
using AracIhaleSistemi.DataAccess.Mapping.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhaleSistemi.DataAccess.DAL.Interfaces
{
    public interface IUyeDAL : IRepo<Uye>
    {
        Task<Uye> GetUye(string email);
        Task<Uye> GetUye(int id);

        List<UyeDTO> GetAllUye();
    }
}
