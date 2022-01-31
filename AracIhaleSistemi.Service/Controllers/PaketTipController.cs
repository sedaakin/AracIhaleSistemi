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
    public class PaketTipController : ControllerBase
    {
        private readonly IPaketTipDAL _dal;
        public PaketTipController(IPaketTipDAL dal)
        {
            _dal = dal;
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<PaketTip> paketTip = _dal.GetAll();
            if (paketTip != null)
            {
                return Ok(paketTip);
            }
            return BadRequest();
        }
    }
}
