using AracIhaleSistemi.DataAccess.DTO;
using AracIhaleSistemi.DataAccess.Mapping.Core;
using AracIhaleSistemi.Service.Auth;
using AracIhaleSistemi.Service.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AracIhaleSistemi.Service.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepo _repo;
        private readonly IConfiguration _conf;
        public AuthController(IAuthRepo repo, IConfiguration conf)
        {
            _repo = repo;
            _conf = conf;
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] RegisterDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();

            }
            var deger = new Uye()
            {
                Email = dto.Email,
                AktifMi=dto.AktifMi,
                AdSoyad=dto.AdSoyad,
                RolID=dto.RolID,
                Telefon=dto.Telefon
            };
            var eklenenKullanici =  _repo.Register(deger, dto.Sifre);

            return StatusCode(201);

        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] LoginDTO dto)
        {
            var user = await _repo.Login(dto.Email, dto.Password);
            if (user == null)
            {
                return null;
            }
            var key = Encoding.ASCII.GetBytes(_conf.GetSection("Token:SecurityKey").Value);

            var description = new SecurityTokenDescriptor()
            {
                Expires = DateTime.Now.AddDays(1),
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[] {
                   new Claim(ClaimTypes.NameIdentifier,user.UyeID.ToString()),
                   new Claim(ClaimTypes.Name,user.Email)
                   }),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)

            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(description);
            var tokenDegeri = tokenHandler.WriteToken(token);
            return Ok(tokenDegeri);


        }
    }
}
