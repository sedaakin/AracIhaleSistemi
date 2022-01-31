using AracIhaleSistemi.DataAccess.DAL.Interfaces;
using AracIhaleSistemi.DataAccess.Mapping.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KomisyonController : ControllerBase
    {
        private readonly IKomisyonDAL _dal;
        public KomisyonController(IKomisyonDAL dal)
        {
            _dal = dal;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<KomisyonUcret> komisyon = _dal.GetAll();
            if (komisyon != null)
            {
                return Ok(komisyon);
            }
            return BadRequest();
        }
        [HttpPost]
        public KomisyonUcret Post(KomisyonUcret komisyon)
        {
            komisyon.CreatedDate = DateTime.Now;
            komisyon.CreatedBy = 2;
            var sonuc = _dal.Add(komisyon);
            return sonuc;
        }
    }
}
