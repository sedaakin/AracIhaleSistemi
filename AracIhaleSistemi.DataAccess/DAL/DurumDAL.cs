using AracIhaleSistemi.DataAccess.DAL.Interfaces;
using AracIhaleSistemi.DataAccess.Mapping.Context;
using AracIhaleSistemi.DataAccess.Mapping.Core;
using AracIhaleSistemi.DataAccess.Mapping.Repo;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using AracIhaleSistemi.DataAccess.DTO;

namespace AracIhaleSistemi.DataAccess.DAL
{
    public class DurumDAL : Repo<Durum, Model1>, IDurumDAL
    {
        private readonly Model1 db;

        public DurumDAL()
        {
            db = new Model1();
        }
        public List<AracDurumDTO> GetAracDurum(int id)
        {
            var deger = (from d in db.Durum
                        join ad in db.AracDurum on d.DurumID equals ad.DurumID
                        where ad.AracID==id
                        select new AracDurumDTO { 
                            Durum=d.DurumAdi,
                            Tarih=ad.CreatedDate
                        }).ToList();
            return deger;
        }
    }
}
