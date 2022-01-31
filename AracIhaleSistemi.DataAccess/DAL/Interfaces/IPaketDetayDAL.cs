using AracIhaleSistemi.DataAccess.DTO;
using AracIhaleSistemi.DataAccess.Mapping.Core;
using AracIhaleSistemi.DataAccess.Mapping.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace AracIhaleSistemi.DataAccess.DAL.Interfaces
{
    public interface IPaketDetayDAL:IRepo<PaketDetay>
    {
        List<PaketDetayDTO> GetDetay();
    }
}
