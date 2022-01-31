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
    public interface IAracDetayDAL:IRepo<AracDetay>
    {
        List<AracDetayDTO> GetDetay(int id);
        AracDTO GetAracDetay(int id);

    }
}
