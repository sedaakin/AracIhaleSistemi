using AracIhaleSistemi.DataAccess.DAL.Interfaces;
using AracIhaleSistemi.DataAccess.DTO;
using AracIhaleSistemi.DataAccess.Mapping.Core;
using AutoMapper;
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
    public class AracListeController : ControllerBase
    {
        private readonly IAracDAL _dal;
        public AracListeController(IAracDAL dal)
        {
            _dal = dal;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<AracDTO> araclar = _dal.GetAllArac();
            if (araclar != null)
            {
                return Ok(araclar);
            }
            
            return BadRequest();
        }
        [HttpPost]
        public Arac Post(Arac arac) 
        {
            var sonuc=_dal.Add(arac);
            return sonuc;
        }
    }
}
