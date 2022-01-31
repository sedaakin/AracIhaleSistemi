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
    public class RolController : ControllerBase
    {
        private readonly IRolDAL _dal;
        public RolController(IRolDAL dal)
        {
            _dal = dal;
        }
        [HttpGet]
        public  IActionResult GetAllRol()
        {
            List<Rol> rol =  _dal.GetAll();
            if (rol != null)
            {
                return Ok(rol);
            }
            return BadRequest();
        }
    }
}
