using AracIhaleSistemi.DataAccess.DAL.Interfaces;
using AracIhaleSistemi.DataAccess.Mapping.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.Service.Auth
{
    public class AuthRepo : IAuthRepo
    {
        private readonly IUyeDAL _dal;
        public AuthRepo( IUyeDAL dal)
        {
            _dal = dal;
        }
        public async Task<Uye> Login(string email, string sifre)
        {
            var user = await _dal.GetUye(email);
            if (user == null)
            {
                return null;

            }
            if (!KontrolEt(sifre, user.SifreHash, user.SifreSalt))
            {
                return null;
            }
            return user;
        }
        private bool KontrolEt(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var passHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < passHash.Length; i++)
                {
                    if (passHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public Uye Register(Uye uye, string sifre)
        {
            byte[] passHash, passSalt;

            Olustur(sifre, out passHash, out passSalt);
            uye.SifreHash = passHash;
            uye.SifreSalt = passSalt;
             _dal.Add(uye);

            return uye;
        }
        private void Olustur(string password, out byte[] passHash, out byte[] passSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                passSalt = hmac.Key;
            }
        }
        public bool UserExist(string email)
        {
            if (_dal.GetUye(email)!=null)
            {
                return false;
            }
            return true;
        }
    }
}
