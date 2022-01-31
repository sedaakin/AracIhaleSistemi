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
    public class NoterController : ControllerBase
    {
        private readonly INoterUcretDAL _dal;
        public NoterController(INoterUcretDAL dal)
        {
            _dal = dal;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<NoterUcret> noter = _dal.GetAll();
            if (noter != null)
            {
                return Ok(noter);
            }
            return BadRequest();
        }
        [HttpPost]
        public NoterUcret Post(NoterUcret noter)
        {
            noter.CreatedDate = DateTime.Now;
            noter.CreatedBy = 2;
            var sonuc = _dal.Add(noter);
            return sonuc;
        }
    }
}
