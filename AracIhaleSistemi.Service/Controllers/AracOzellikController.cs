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
    public class AracOzellikController : ControllerBase
    {
        private readonly IAracOzellikDAL _dal;
        public AracOzellikController(IAracOzellikDAL dal)
        {
            _dal = dal;
        }
        [HttpGet]
        public  IActionResult Get(int id)
        {
            List<AracOzellik> ozellik = _dal.GetAll(x=>x.UstOzellikID==id&&x.AracOzellikID!=x.UstOzellikID);
            if (ozellik != null)
            {
                return Ok(ozellik);
            }
            return BadRequest();
        }
    }
}
