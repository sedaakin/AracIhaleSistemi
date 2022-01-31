using AracIhaleSistemi.DataAccess.DAL;
using AracIhaleSistemi.DataAccess.DAL.Interfaces;
using AracIhaleSistemi.DataAccess.Mapping.Core;
using Microsoft.AspNetCore.Authorization;
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
    public class TramerController : ControllerBase
    {
        private readonly ITramerDAL _dal;
        public TramerController(ITramerDAL dal)
        {
            _dal = dal;
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<Tramer> tramer = _dal.GetAll();
            if (tramer != null)
            {
                return Ok(tramer);
            }
            return BadRequest();
        }
    }
}
