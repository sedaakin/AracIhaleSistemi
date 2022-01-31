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
    public class NoterController : Controller
    {
        private readonly NoterApiService _noterApi;

        public NoterController(NoterApiService noterApi)

        {
            _noterApi = noterApi;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.noter = await _noterApi.GetAll();
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(NoterVM noter)
        {
            var sonuc = _noterApi.PostKomisyon(noter);
            return RedirectToAction("Index");
        }
    }
}
