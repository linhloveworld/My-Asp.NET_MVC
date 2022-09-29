using Microsoft.AspNetCore.Mvc;
using WebApplication_29_9.Models.Process;

namespace WebApplication_29_9.Controllers
{
    public class DemoController : Controller
    {
        StringProcess strPro = new StringProcess();
        public IActionResult XulyChuoi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult XuLyChuoi(string strInput)
        {
            ViewBag.message = strPro.LowerToUpper(strInput);
            ViewBag.message = strPro.UpperToLower(strInput);
            ViewBag.thongTin  = strPro.RemoveRemainingWhiteSpace(strInput);
            return View();
        }
    }
}
