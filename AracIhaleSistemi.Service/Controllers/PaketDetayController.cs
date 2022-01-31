using AracIhaleSistemi.DataAccess.DAL.Interfaces;
using AracIhaleSistemi.DataAccess.DTO;
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
    public class PaketDetayController : ControllerBase
    {
        private readonly IPaketDetayDAL _dal;
        public PaketDetayController(IPaketDetayDAL dal)
        {
            _dal = dal;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<PaketDetayDTO> pakeyDetay = _dal.GetDetay();
            if (pakeyDetay != null)
            {
                return Ok(pakeyDetay);
            }
            return BadRequest();
        }
        [HttpPost]
        public PaketDetay Post(PaketDetay detay)
        {
            detay.CreatedDate = DateTime.Now;
            detay.CreatedBy = 2;
            var sonuc = _dal.Add(detay);
            return sonuc;
        }
    }
}
