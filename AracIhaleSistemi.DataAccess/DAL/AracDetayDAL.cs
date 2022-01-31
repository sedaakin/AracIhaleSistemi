using AracIhaleSistemi.DataAccess.DAL.Interfaces;
using AracIhaleSistemi.DataAccess.DTO;
using AracIhaleSistemi.DataAccess.Mapping.Context;
using AracIhaleSistemi.DataAccess.Mapping.Core;
using AracIhaleSistemi.DataAccess.Mapping.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhaleSistemi.DataAccess.DAL
{
    public class AracDetayDAL : Repo<AracDetay, Model1>, IAracDetayDAL
    {
        private readonly Model1 db;
        public AracDetayDAL()
        {
            db = new Model1();
        }
        public List<AracDetayDTO> GetDetay(int id)
        {
            List<AracDetayDTO> detay = (from d in db.AracDetay
                                       join o in db.AracOzellik on d.AracOzellikID equals o.AracOzellikID
                                       join uo in db.AracOzellik on o.UstOzellikID equals uo.UstOzellikID
                                       where d.AracID==id
                                       select new AracDetayDTO
                                       {
                                           AltOzellikID =  o.AracOzellikID,
                                           UstOzellikID=o.UstOzellikID,
                                           AltOzellik=o.OzellikAdi,
                                           UstOzellik=uo.OzellikAdi
                                       }).ToList();
            return detay;
        }
        public AracDTO GetAracDetay(int id)
        {
            var deger= (from d in db.AracDetay
                            join o in db.AracOzellik on d.AracOzellikID equals o.AracOzellikID
                            where d.AracID == id
                        select new {o.OzellikAdi,o.UstOzellikID });
            AracDTO detay = new AracDTO { Marka=deger.Where(a=>a.UstOzellikID==5).Select(a=>a.OzellikAdi).FirstOrDefault(), Model = deger.Where(a => a.UstOzellikID == 25).Select(a => a.OzellikAdi).FirstOrDefault() };
            return detay;
        }

    }
}
