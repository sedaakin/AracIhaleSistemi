using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI.Areas.AdminArea.Controllers
{
    public class BireyselAracAlimController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detay()
        {
            return View();
        }
    }
}
