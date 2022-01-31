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
    public class PaketController : Controller
    {
        private readonly PaketDetayApiService _detayApi;
        private readonly PaketTipApiService _tipApi;
        public PaketController(PaketDetayApiService detayApi, PaketTipApiService tipApi)
        {
            _detayApi = detayApi;
            _tipApi = tipApi;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.PaketDetay =await _detayApi.GetAll();
            return View();
        }
        public async Task<IActionResult> Add()
        {
            ViewBag.PaketTip =await _tipApi.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Add(PaketDetayAddVM detay)
        {
            var sonuc = _detayApi.PostPaket(detay);
            return RedirectToAction("Index");
        }
    }
}
