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
    public class DurumController : ControllerBase
    {
        private readonly IDurumDAL _dal;
        public DurumController(IDurumDAL dal)
        {
            _dal = dal;
        }
        [HttpGet]
        public IActionResult Get(int id)
        {

            List<Durum> durumlar = _dal.GetAll(x => x.UstDurumID == id&&x.DurumID!=x.UstDurumID);
            if (durumlar != null)
            {
                return Ok(durumlar);
            }
            return BadRequest();
        }
    }
}
