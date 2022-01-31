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
    public class AracDetayController : ControllerBase
    {
        private readonly IAracDetayDAL _dal;
        public AracDetayController(IAracDetayDAL dal)
        {
            _dal = dal;
        }
        [HttpGet]
        public IActionResult GetDetay(int id)
        {
            List<AracDetayDTO> detay=_dal.GetDetay(id);
            if (detay != null)
            {
                return Ok(detay);
            }
            return BadRequest();
        }
        [HttpGet]
        public IActionResult GetAracDetayDetay(int id)
        {
            AracDTO detay = _dal.GetAracDetay(id);
            if (detay != null)
            {
                return Ok(detay);
            }
            return BadRequest();
        }

    }
}
