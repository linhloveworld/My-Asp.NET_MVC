using Fluent.Infrastructure.FluentModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using VuLinh_BTH2_17_11.Models;
using VuLinh_BTH2_3_11.Models;
using VuLinh_BTH2_3_11.Models.Process;

namespace VuLinh_BTH2_17_11.Controllers
{
    public class FacultyController : Controller
    {
        private readonly ApplicationDbContext _context;
        private ApplicationDbContext context;

        public FacultyController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Faculty.ToListAsync());
        }

        private IActionResult View(object p)
        {
            throw new NotImplementedException();
        }

        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> CreateAsync(Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faculty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(faculty);
        }

        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}
