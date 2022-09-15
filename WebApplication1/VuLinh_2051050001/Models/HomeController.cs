using AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace VuLinh_2051050001.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public class GiaiPhuongTrinh
        {
            public string GiaiPhuongTrinhBacMot(string heSoA, string heSoB) 
            { 
                double a,b,x;
                String ThongBao;
                a = Convert.ToDouble(heSoA);
                b = Convert.ToDouble(heSoB);
                if (a == 0)
                {
                    if(b != 0)
                    {
                        ThongBao = "Phuong trinh vo nghiem";
                    }
                    else
                    {
                        ThongBao = "Phuong trinh vo so nghiem";
                    }
                }
                else
                {
                    x = -b / a;
                    ThongBao = "Phuong trinh co nghiem x: "+ x;
                }
                return ThongBao;
            }   
        }
    }
}
