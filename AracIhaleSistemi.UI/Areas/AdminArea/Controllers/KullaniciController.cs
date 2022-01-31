using AracIhaleSistemi.UI.ApiServices;
using AracIhaleSistemi.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class KullaniciController : Controller
    {
        private readonly UyeApiService _uyeApi;
        public KullaniciController(UyeApiService uyeApi)
        {
            _uyeApi = uyeApi;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.uyeler = await _uyeApi.GetAllUye();
            ViewBag.cmbRol = await _uyeApi.GetAllRol();
            return View();
        }
        public async Task<IActionResult> Add()
        {
            ViewBag.cmbRol = await _uyeApi.GetAllRol();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(UyeAddVM uye)
        {
            var sonuc = await _uyeApi.PostUye(uye);
            return View();
        }
        public async Task<IActionResult> Update(UyeVM uye)
        {
            ViewBag.cmbRol = await _uyeApi.GetAllRol();
            UyeUpdateVM uyeUpdate = new UyeUpdateVM {UyeID=uye.ID,AdSoyad=uye.AdSoyad,Email=uye.Email,AktifMi=uye.AktifMi,RolID=uye.RolID,Telefon=uye.Telefon };
            ViewBag.uye = uyeUpdate;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(UyeUpdateVM uye)
        {
            var sonuc = await _uyeApi.PutUye(uye);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var sonuc = await _uyeApi.DeleteUye(id);
            return RedirectToAction("Index");
        }
    }
}
