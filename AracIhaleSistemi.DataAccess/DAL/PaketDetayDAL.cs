using AracIhaleSistemi.DataAccess.DAL.Interfaces;
using AracIhaleSistemi.DataAccess.DTO;
using AracIhaleSistemi.DataAccess.Mapping.Context;
using AracIhaleSistemi.DataAccess.Mapping.Core;
using AracIhaleSistemi.DataAccess.Mapping.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AracIhaleSistemi.DataAccess.DAL
{
    public class PaketDetayDAL : Repo<PaketDetay, Model1>, IPaketDetayDAL
    {
        private readonly Model1 db;
        public PaketDetayDAL()
        {
            db = new Model1();
        }
        public List<PaketDetayDTO> GetDetay()
        {
            List<PaketDetayDTO> detay = (from d in db.PaketDetay
                                        join t in db.PaketTip on d.PaketTipID equals t.PaketTipID
                                        select new PaketDetayDTO
                                        {
                                            PaketDetayID=d.PaketDetayID,
                                            PaketTip=t.PaketTipi,
                                            Parametre=d.Parametre==false?"Aylık araç sayısı":"Komisyon Tutarı",
                                            Tanimlama=d.Tanimlama

                                        }).ToList();
            return detay;
        }
    }
}
