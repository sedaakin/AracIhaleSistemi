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
    public class UyeDAL : Repo<Uye, Model1>, IUyeDAL
    {
        private readonly Model1 db;
        public UyeDAL()
        {
            db = new Model1();
        }
        public async Task<Uye> GetUye(string email)
        {

            var deger = db.Uye.FirstOrDefault(a=>a.Email==email);

            return deger;
        }
        public async Task<Uye> GetUye(int id)
        {

            var deger = db.Uye.FirstOrDefault(a => a.UyeID == id);

            return deger;
        }
        public List<UyeDTO> GetAllUye()
        {

            var deger = (from u in db.Uye
                        join r in db.Rol on u.RolID equals r.RolID
                        select new UyeDTO {
                            ID=u.UyeID,
                            AdSoyad=u.AdSoyad,
                            Email=u.Email,
                            Telefon=u.Telefon,
                            RolAdi=r.Rol1,
                            AktifMi=u.AktifMi,
                            RolID=u.RolID
                        }).ToList();

            return deger;
        }

    }
}
