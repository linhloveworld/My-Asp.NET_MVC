using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using VuLinh_BTH2_3_11.Models.Process;
using VuLinh_BTH2_3_11.Models;
using Microsoft.EntityFrameworkCore;

namespace VuLinh_BTH2_3_11.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private ExcelProcess _excelProcess = new ExcelProcess();
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employee.ToListAsync());
        }
        public bool EmployeeExists(string id)
        {
            return _context.Employee.Any(e => e.EmpID == id);
        }
        public DbSet<VuLinh_BTH2_3_11.Models.Employee> Employee { get; set; }
        /*public IActionResult Index()
        {
            return View();
        }*/
        public async Task<IActionResult> Upload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file != null)
            {
                string fileExtension = Path.GetExtension(file.FileName);
                if(fileExtension != ".xls" && fileExtension != ".xlsx")
                {
                    ModelState.AddModelError("", "Please choose excel file to upload!");
                }
                else
                {
                    var fileName = DateTime.Now.ToShortTimeString() + fileExtension;
                    var filePath = Path.Combine(Directory.GetCurrentDirectory() +
                        "/Upload/Excels", fileName);
                    var fileLocation = new FileInfo(filePath).ToString();
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        //save file to server
                        await file.CopyToAsync(stream);
                        //read data from file and write to database
                        var dt = _excelProcess.ExcelToDataTable(fileLocation);
                        //using for loop to read data from dt
                        for(int i=0; i < dt.Rows.Count; i++)
                        {
                            //create a new Employee object;
                            var emp = new Employee();
                            //set values for attributes
                            emp.EmpID = dt.Rows[i][0].ToString();
                            emp.EmpName = dt.Rows[i][0].ToString();
                            emp.Address = dt.Rows[i][0].ToString();
                            //add object to Context
                            _context.Employee.Add(emp);
                        }
                        //save to database
                        await _context.SaveChangeAsync();
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            return View();
        }
    }
}
