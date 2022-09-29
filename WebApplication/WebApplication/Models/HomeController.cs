using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Models
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
                    if (b != 0)
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
                    ThongBao = "Phuong trinh co nghiem x: " + x;
                }
                return ThongBao;
            }
        }
        public class GiaiPhuongTrinh2
        {
            public static string GiaiPhuongTrinhBacHai(string heSoA, string heSoB,
                string heSoC)
            {
                double a, b,c,denta, x1,x2;
                String ThongBao;
                a = Convert.ToDouble(heSoA);
                b = Convert.ToDouble(heSoB);
                c = Convert.ToDouble(heSoC);
                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                        {
                            ThongBao = "PT có vô số nghiệm";
                        }
                        else //c khac 0
                        {
                            ThongBao = "PT có vô nghiệm";
                        }
                    }
                    else // b khac 0
                    {
                        ThongBao = String.Format("PT có nghiệm là {0}", ((-c) / b));
                    }
                }
                else //a khac 0
                {
                    denta = b * b - 4 * a * c;
                    if (denta < 0)
                    {
                        ThongBao = "PT vô nghiệm";
                    }
                    else if (denta == 0)
                    {
                        ThongBao= String.Format("PT có nghiệm kép là  {0}", ((-b) / (2 * a)));
                    }
                    else //denta>0
                    {
                        x1 = (-b + Math.Sqrt(denta)) / (2 * a);
                        x2 = (-b - Math.Sqrt(denta)) / (2 * a);
                        ThongBao = String.Format("PT có 2 nghiệm kép là x1 = {0}\n va x2= {1}", x1, x2);
                    }
                }
                return ThongBao;
            }
        }
    }
}
