using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CMS.Models;
using CMS.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using OfficeOpenXml;
using System.Text;
using System.Globalization;

namespace CMS.Controllers
{
    public class ImportInfoesController : Controller
    {
        private readonly CMSContext _context;
        private IHostingEnvironment _hostingEnvironment;
        public ImportInfoesController(IHostingEnvironment hostingEnvironment)
        {
            _context = new CMSContext();
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: ImportInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ImportInfo.ToListAsync());
        }

        // GET: ImportInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var importInfo = await _context.ImportInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (importInfo == null)
            {
                return NotFound();
            }

            return View(importInfo);
        }

        // GET: ImportInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ImportInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StartDate,EndDate,Name,Pax,SIC,Host,ForeignVisit")] ImportInfo importInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(importInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(importInfo);
        }

        // GET: ImportInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var importInfo = await _context.ImportInfo.FindAsync(id);
            if (importInfo == null)
            {
                return NotFound();
            }
            return View(importInfo);
        }

        // POST: ImportInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StartDate,EndDate,Name,Pax,SIC,Host,ForeignVisit")] ImportInfo importInfo)
        {
            if (id != importInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(importInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImportInfoExists(importInfo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(importInfo);
        }

        // GET: ImportInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var importInfo = await _context.ImportInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (importInfo == null)
            {
                return NotFound();
            }

            return View(importInfo);
        }

        // POST: ImportInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var importInfo = await _context.ImportInfo.FindAsync(id);
            _context.ImportInfo.Remove(importInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImportInfoExists(int id)
        {
            return _context.ImportInfo.Any(e => e.Id == id);
        }

        [HttpPost]
        public async Task<IActionResult> Import(IFormFile excelfile) {
            string webrootpath = _hostingEnvironment.WebRootPath;
            string filename =$"{ Guid.NewGuid()}.xlsx";
            FileInfo file = new FileInfo(Path.Combine(webrootpath, filename));
            try
            {
                using (FileStream fs = new FileStream(file.ToString(), FileMode.Create)) {
                    excelfile.CopyTo(fs);
                    fs.Flush();
                }
                using (ExcelPackage package = new ExcelPackage(file)) {
                    StringBuilder sb = new StringBuilder();
                  
                    foreach (ExcelWorksheet worksheet in package.Workbook.Worksheets) {
                        int sumrow = worksheet.Dimension.Rows;
                        int sumclm = worksheet.Dimension.Columns;
                        ImportInfoCursor infoCursor = new ImportInfoCursor();
                        for (int row = 1; row <= sumrow; row++) {
                            for (int clm = 1; clm <= sumclm; clm++) {
                                //sb.Append(worksheet.Cells[row, clm].Value.ToString()+"\t");
                                if (row == 1)
                                {
                                    switch (worksheet.Cells[row, clm].Value.ToString())
                                    {
                                        case "Start DateTime":
                                            infoCursor.StartDate = clm;
                                            break;
                                        case "End DateTime":
                                            infoCursor.EndDate = clm;
                                            break;
                                        case "Name":
                                            infoCursor.Name = clm;
                                            break;
                                        case "Pax":
                                            infoCursor.Pax = clm;
                                            break;
                                        case "SIC":
                                            infoCursor.SIC = clm;
                                            break;
                                        case "Host":
                                            infoCursor.Host = clm;
                                            break;
                                        case "Foreign Visit":
                                            infoCursor.ForeignVisit = clm;
                                            break;
                                    }
                                }
                                
                            }
                           // if (Check(infoCursor, sumclm))
                           // {

                                if (row != 1)
                                {
                                    DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();

                                    dtFormat.ShortDatePattern = "yyyy/MM/dd HH:mm:ss";
                                    try
                                    {
                                        ImportInfo importInfo = new ImportInfo();

                                        importInfo.StartDate = Convert.ToDateTime(worksheet.Cells[row, infoCursor.StartDate].Value.ToString(), dtFormat);
                                    try
                                    {
                                        importInfo.EndDate = Convert.ToDateTime(worksheet.Cells[row, infoCursor.EndDate].Value.ToString(), dtFormat);
                                    }
                                    catch {
                                        importInfo.EndDate = null ;
                                    }
                                       string companyname= worksheet.Cells[row, infoCursor.Name].Value.ToString();
                                    string[] name = companyname.Split(new string[] { "Visit by " }, StringSplitOptions.RemoveEmptyEntries);
                                    companyname = "";
                                    foreach (string s in name) {
                                        companyname += s;
                                    }
                                    importInfo.Name = companyname;
                                        importInfo.Pax = int.Parse(worksheet.Cells[row, infoCursor.Pax].Value.ToString());
                                        importInfo.Host = worksheet.Cells[row, infoCursor.Host].Value.ToString();
                                        importInfo.SIC = worksheet.Cells[row, infoCursor.SIC].Value.ToString();

                                        if (worksheet.Cells[row, infoCursor.ForeignVisit].Value.ToString() == "yes" || worksheet.Cells[row, infoCursor.ForeignVisit].Value.ToString() == "true")
                                        {
                                            importInfo.ForeignVisit = true;
                                        }
                                        else
                                        {
                                            importInfo.ForeignVisit = false;
                                        }

                                        _context.Add(importInfo);
                                        await _context.SaveChangesAsync();
                                    }
                                    catch (Exception e)
                                    {
                                        return Content(e.Message.ToString() + e.StackTrace.ToString() + infoCursor.ForeignVisit.ToString());
                                    }
                                }
                           // }
                           // else {
                           //     return Content("表头有问题");
                           // }
                            //sb.Append(Environment.NewLine);
                        }
                    }
                    //return Content(sb.ToString());
                    file.Delete();
                }
            }
            catch (Exception e) { 

                }
            return RedirectToAction("index");
        }

        private bool Check(ImportInfoCursor infoCursor,int sumclm)
        {
            if (infoCursor.StartDate > sumclm || infoCursor.StartDate < 1) {
                return false;
            }else if (infoCursor.EndDate > sumclm || infoCursor.EndDate < 1)
            {
                return false;
            }
            else if (infoCursor.Name > sumclm || infoCursor.Name < 1)
            {
                return false;
            }
            else if (infoCursor.Pax > sumclm || infoCursor.Pax < 1)
            {
                return false;
            }
            else if (infoCursor.SIC > sumclm || infoCursor.SIC < 1)
            {
                return false;
            }
            else if (infoCursor.Host > sumclm || infoCursor.Host < 1)
            {
                return false;
            }
            else if (infoCursor.ForeignVisit > sumclm || infoCursor.ForeignVisit < 1)
            {
                return false;
            }
            return true;
        }

        public class ImportInfoCursor
        {
            public int StartDate { get; set; }
            public int EndDate { get; set; }
            public int Name { get; set; }
            public int Pax { get; set; }
            public int SIC { get; set; }
            public int Host { get; set; }
            public int ForeignVisit { get; set; }
        }
    }
}
