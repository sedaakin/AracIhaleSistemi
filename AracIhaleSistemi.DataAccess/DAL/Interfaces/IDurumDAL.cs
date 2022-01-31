using AracIhaleSistemi.DataAccess.DTO;
using AracIhaleSistemi.DataAccess.Mapping.Core;
using AracIhaleSistemi.DataAccess.Mapping.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace AracIhaleSistemi.DataAccess.DAL.Interfaces
{
    public interface IDurumDAL:IRepo<Durum>
    {
        List<AracDurumDTO> GetAracDurum(int id);
    }
}
