using AracIhaleSistemi.UI.ApiServices;
using AracIhaleSistemi.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class AracController : Controller
    {
        private readonly AracApiService _AracApi;
        private readonly DurumApiService _DurumApi;

        public AracController(AracApiService aracApi, DurumApiService durumApi)

        {
            _AracApi = aracApi;
            _DurumApi = durumApi;
        }     
        public async Task<IActionResult> Index()
        {
            ViewBag.cmbMarka = await _AracApi.GetOzellik(5);
            ViewBag.cmbDurum = await _DurumApi.GetAsync(1);
            ViewBag.AracListe = await _AracApi.GetAllAracsAsync(/*_token.TokenGetir()*/);
            return View();
        }
        public async Task<IActionResult> IndexF(List<AracVM> araclar)
        {
            ViewBag.cmbMarka = await _AracApi.GetOzellik(5);
            ViewBag.cmbDurum = await _DurumApi.GetAsync(1);
            ViewBag.AracListe = araclar;
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            ViewBag.cmbMarka = await _AracApi.GetOzellik(5);
            ViewBag.cmbYakit = await _AracApi.GetOzellik(1);
            ViewBag.cmbVites = await _AracApi.GetOzellik(2);
            ViewBag.cmbGovde = await _AracApi.GetOzellik(3);
            ViewBag.cmbVersion = await _AracApi.GetOzellik(38);
            ViewBag.cmbRenk = await _AracApi.GetOzellik(4);
            ViewBag.cmbDonanım = await _AracApi.GetOzellik(7);
            ViewBag.cmbDurum = await _DurumApi.GetAsync(1);
            ViewBag.cmbTramerDurum = await _DurumApi.GetAsync(4);
            ViewBag.cmbTramer = await _AracApi.GetTramer();
            ViewBag.AracListe = await _AracApi.GetAllAracsAsync(/*_token.TokenGetir()*/);
            return View();
        }
        [HttpPost]
        public  ActionResult Add(AracAddVM arac) 
        {
            
            return RedirectToAction("Update");
        }
        [HttpGet]
        public async Task<IActionResult> Tramer()
        {
            ViewBag.cmbTramerDurum = await _DurumApi.GetAsync(4);
            ViewBag.cmbTramer = await _AracApi.GetTramer();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Tramer(AracTramerAddVM tramer)
        {

            return RedirectToAction("Update");
        }
        [HttpPost]
        public ViewResult IlanAdd(AracAddVM arac) 
        {
            return null;
        }
        public async Task<IActionResult> Update()
        {
            ViewBag.cmbMarka = await _AracApi.GetOzellik(5);
            ViewBag.cmbYakit = await _AracApi.GetOzellik(1);
            ViewBag.cmbVites = await _AracApi.GetOzellik(2);
            ViewBag.cmbGovde = await _AracApi.GetOzellik(3);
            ViewBag.cmbVersion = await _AracApi.GetOzellik(38);
            ViewBag.cmbRenk = await _AracApi.GetOzellik(4);
            ViewBag.cmbDonanım = await _AracApi.GetOzellik(7);
            ViewBag.cmbDurum = await _DurumApi.GetAsync(1);
            ViewBag.cmbTramerDurum = await _DurumApi.GetAsync(4);
            ViewBag.cmbTramer = await _AracApi.GetTramer();
            ViewBag.AracListe = await _AracApi.GetAllAracsAsync(/*_token.TokenGetir()*/);
            return View();
        }
        public async Task<JsonResult> ModelGetir(string markaId)
        {
            SelectList rt = new SelectList(await _AracApi.GetOzellik(int.Parse(markaId)), "AracOzellikID", "OzellikAdi");
            return Json(rt);
        }
        [HttpPost]
        public async Task<IActionResult> AracFiltre(AracFiltreVM filtre)
        {
            var list = _AracApi.Filtre(filtre);

            return RedirectToAction("IndexF",list);
        }
    }
}
