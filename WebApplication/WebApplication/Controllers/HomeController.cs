using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication.Models;
using static WebApplication.Models.HomeController;

namespace WebApplication.Controllers
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
        public IActionResult GiaiPhuongTrinhBacMot(String heSoA, String heSoB, GiaiPhuongTrinh giaiPhuongTrinh)
        {
            string thongBaoBacMot = giaiPhuongTrinh.GiaiPhuongTrinhBacMot(heSoA, heSoB);
            ViewBag.Message = thongBaoBacMot;
            return View();
        }
        public IActionResult GiaiPhuongTrinhBacHai()
        {
            return View();
        }
        public IActionResult GiaiPhuongTrinhBacHai(string heSoA, string heSoB, string heSoC)
        {
            string thongbaoBacHai = GiaiPhuongTrinh2.GiaiPhuongTrinhBacHai(heSoA, heSoB, heSoC);
            ViewBag.Message = thongbaoBacHai;
            return View();
        }
    }
}