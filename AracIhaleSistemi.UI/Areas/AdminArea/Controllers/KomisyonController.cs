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
    public class KomisyonController : Controller
    {
        private readonly KomisyonApiService _komisyonApi;

        public KomisyonController(KomisyonApiService komisyonApi)

        {
            _komisyonApi = komisyonApi;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.komisyonlar =await _komisyonApi.GetAll();
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(KomisyonVM komisyon)
        {
            var sonuc = _komisyonApi.PostKomisyon(komisyon);
            return RedirectToAction("Index");
        }
    }
}
