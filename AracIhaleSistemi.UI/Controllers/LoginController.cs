using AracIhaleSistemi.UI.ApiServices;
using AracIhaleSistemi.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginApiService _loginApi;
        public LoginController(LoginApiService loginApi)
        {
            _loginApi = loginApi;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserVM user)
        {
            var token=_loginApi.Login(user.Email,user.Password);
            return RedirectToAction("Index","Home", new { area = "AdminArea" });
        }
    }
}
