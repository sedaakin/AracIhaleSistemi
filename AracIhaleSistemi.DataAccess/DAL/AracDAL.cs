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
    public class AracDAL : Repo<Arac, Model1>, IAracDAL
    {
        private readonly Model1 db;
        
        public AracDAL()
        {
            db = new Model1();
        }
        public List<AracDTO> GetAllArac()
        {
            List<AracDTO> araclar = (from a in db.Arac
                                     select new AracDTO { 
                                        ID=a.AracID,
                                        KaydedenKullanici=(new UyeDAL().GetUye(a.CreatedBy)).Result.AdSoyad,
                                        KayitZamani=a.CreatedDate,
                                        AktifMi=a.AktifMi
                                     }).ToList();
            foreach (var item in araclar)
            {
                var detay = new AracDetayDAL().GetAracDetay(item.ID);
                var durum = (new DurumDAL().GetAracDurum(item.ID)).OrderByDescending(a=>a.Tarih).FirstOrDefault().Durum;
                item.Marka = detay.Marka;
                item.Model = detay.Model;
                item.Durum = durum;
            }
            return araclar;
        }
    }
}
