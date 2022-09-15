using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VuLinh_2051050001.Models;

namespace VuLinh_2051050001.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult GiaiPhuongTrinhBacMot()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GiaiPhuongTrinhBacMot(String heSoA, String heSoB, String heSoC)
        {
            string ThongBaoBacMot = GiaiPhuongTrinh.GiaiPhuongTrinhBacMot(heSoA, heSoB);
            ViewBag.Message = ThongBaoBacMot;
            return View();   
        }
        
    }
}