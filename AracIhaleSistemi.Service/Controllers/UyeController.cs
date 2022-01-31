using AracIhaleSistemi.DataAccess.DAL.Interfaces;
using AracIhaleSistemi.DataAccess.DTO;
using AracIhaleSistemi.DataAccess.Mapping.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AracIhaleSistemi.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UyeController : ControllerBase
    {
        private readonly IUyeDAL _dal;
        public UyeController(IUyeDAL dal)
        {
            _dal = dal;
        }
        //[HttpGet]
        //public async Task<IActionResult> GetUye(string email)
        //{

        //    Uye uye = await _dal.GetUye(email);
        //    if (uye != null)
        //    {
        //        return Ok(uye);
        //    }
        //    return BadRequest();
        //}
        [HttpGet]
        public async Task<IActionResult> GetAllUye()
        {
            List<UyeDTO> uyeler = _dal.GetAllUye();
            if (uyeler != null)
            {
                return Ok(uyeler);
            }
            return BadRequest();
        }
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UyeUpdateDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();

            }
            Uye yeniUye = _dal.Get(a => a.UyeID == dto.UyeID);
            yeniUye.AdSoyad = dto.AdSoyad;
            yeniUye.Email = dto.Email;
            yeniUye.Telefon = dto.Telefon;
            yeniUye.RolID = dto.RolID;
            yeniUye.AktifMi = dto.AktifMi;
            yeniUye.ModifiedDate = DateTime.Now;

            var sonuc = _dal.Update(yeniUye);

            return StatusCode(201);

        }
        [HttpDelete]
        public async Task<ActionResult> Delete([FromBody] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();

            } ;
            var sonuc = _dal.Delete(_dal.Get(a => a.UyeID == id));

            return StatusCode(201);

        }

    }
}
