using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CMS.Models;
using CMS.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text;
using OfficeOpenXml;
using Microsoft.AspNetCore.Hosting;
using System.Globalization;

namespace CMS.Controllers
{
    [Authorize]
    public class VisitsController : Controller
    {
        private readonly CMSContext _context;
        private IHostingEnvironment _hostingEnvironment;

        public VisitsController(IHostingEnvironment hostingEnvironment)
        {
            _context = new CMSContext();
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Visits
        public async Task<IActionResult> Index()
        {
            // ViewBag.fromdate = new DateTime();
            // ViewBag.enddate = new DateTime();
            ViewBag.rows = 5;
            var content = await _context.Visits.ToListAsync();
            return View(content);
        }
        [HttpPost]
        public async Task<IActionResult> Index(DateTime fromdate,DateTime enddate,int rows) {
            if (rows <= 0)
            {
                ViewBag.error = "The entered rows number is invalid and has been reset to 5";
                ViewBag.rows = 5;
                var content = await _context.Visits.ToListAsync();
                return View(content);
            }
            else if (fromdate > enddate&&enddate!=new DateTime()) {
                ViewBag.error = "Invalid date";
                ViewBag.rows = rows;
                var content = await _context.Visits.ToListAsync();
                return View(content);
            }
            else if (fromdate != new DateTime() && enddate != new DateTime())
            {
                var content = await _context.Visits.Where(s => s.StartDate >= fromdate && s.StartDate <= enddate).ToListAsync();
                ViewBag.fromdate = fromdate;
                ViewBag.enddate = enddate;
                ViewBag.rows = rows;
                return View(content);
            }
            else if (fromdate != new DateTime())
            {
                var content = await _context.Visits.Where(s => s.StartDate >= fromdate).ToListAsync();
                ViewBag.fromdate = fromdate;
                ViewBag.rows = rows;
                return View(content);
            }
            else
            {
                var content = await _context.Visits.ToListAsync();
                ViewBag.rows = rows;
                return View(content);
            }

            //return Content(fromdate.ToString() + "  " + enddate.ToString());
        }


        // GET: Visits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visits = await _context.Visits
                .SingleOrDefaultAsync(m => m.VisitId == id);
            if (visits == null)
            {
                return NotFound();
            }

            return View(visits);
        }

        // GET: Visits/Create
        public IActionResult Create()
        {
            //var VisitTypelist = _context.VisitType.FromSql("SELECT visitTypeId, visitType FROM VisitType").ToList();
            //var selectList = new SelectList(VisitTypelist, "visitTypeId", "visitType");
            //ViewBag.visitTypes = selectList;
            ////var CompanyTypelist = _context.CompanyType.FromSql("SELECT companyTypeId, companyType FROM CompanyType").ToList();
            //var CompanyTypelist = _context.CompanyType.ToList();
            //var companySelectList = new SelectList(CompanyTypelist, "companyTypeId", "companyType");
            //ViewBag.CompanyType = companySelectList;
            
            return View();
        }
        

        // POST: Visits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,StartDate,EndDate,Pax,SIC,Host,ForeignVisit")] Visits visits)
        {
            if (ModelState.IsValid)
            {
                if (visits.StartDate < DateTime.Now)
                {
                    ViewBag.error = "The start DateTime entered is in the past. Please choose a date in the future";
                    return View(visits);
                }
                if (visits.StartDate.Day == DateTime.Now.Day && visits.StartDate.Month == DateTime.Now.Month)
                {
                    ViewBag.error = "Visit date cannot be today";
                    return View(visits);
                }
                if (visits.EndDate <visits.StartDate)
                {
                    ViewBag.error = "The end time entered is before at the start time. Please select a future date";
                    return View(visits);
                }
                visits.dateCreated = DateTime.Now;
                _context.Add(visits);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(visits);
        }

        // GET: Visits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visits = await _context.Visits.SingleOrDefaultAsync(m => m.VisitId == id);
            if (visits == null)
            {
                return NotFound();
            }
            //var VisitTypelist = _context.VisitType.FromSql("SELECT visitTypeId, visitType FROM VisitType").ToList();
            //var selectList = new SelectList(VisitTypelist, "visitTypeId", "visitType");
            //ViewBag.visitTypes = selectList;
            //var CompanyTypelist = _context.CompanyType.FromSql("SELECT companyTypeId, companyType FROM CompanyType").ToList();
            //var companySelectList = new SelectList(CompanyTypelist, "companyTypeId", "companyType");
            //ViewBag.CompanyType = companySelectList;
            return View(visits);
        }

        // POST: Visits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Visits visits)
        {
            if (id != visits.VisitId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
               

                try
                {
                    _context.Update(visits);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VisitsExists(visits.VisitId))
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
            return View(visits);
        }

        // GET: Visits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visits = await _context.Visits
                .SingleOrDefaultAsync(m => m.VisitId == id);
            if (visits == null)
            {
                return NotFound();
            }

            return View(visits);
        }

        // POST: Visits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var visits = await _context.Visits.SingleOrDefaultAsync(m => m.VisitId == id);
            _context.Visits.Remove(visits);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VisitsExists(int id)
        {
            return _context.Visits.Any(e => e.VisitId == id);
        }
        public IActionResult QueryView()
        {
            return View();
        }

        public async Task<IActionResult> QueryVisit(Visits visits)
        {
            
            //var visit = from m in _context.Visits
            //              select m;

            //if (!String.IsNullOrEmpty(visits.companyName))
            //{
            //    visit = visit.Where(s => s.companyName.Contains(visits.companyName));
            //}

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Import(IFormFile excelfile)
        {
            string webrootpath = _hostingEnvironment.WebRootPath;
            string filename = $"{ Guid.NewGuid()}.xlsx";
            FileInfo file = new FileInfo(Path.Combine(webrootpath, filename));
            try
            {
                using (FileStream fs = new FileStream(file.ToString(), FileMode.Create))
                {
                    excelfile.CopyTo(fs);
                    fs.Flush();
                }
                using (ExcelPackage package = new ExcelPackage(file))
                {
                    //StringBuilder sb = new StringBuilder();

                    foreach (ExcelWorksheet worksheet in package.Workbook.Worksheets)
                    {
                        int sumrow = worksheet.Dimension.Rows;
                        int sumclm = worksheet.Dimension.Columns;
                        ImportInfoCursor infoCursor = new ImportInfoCursor();
                        for (int row = 1; row <= sumrow; row++)
                        {
                            for (int clm = 1; clm <= sumclm; clm++)
                            {
                                //sb.Append(worksheet.Cells[row, clm].Value.ToString()+"\t");
                                if (row == 1)
                                {
                                    switch (worksheet.Cells[row, clm].Value.ToString())
                                    {
                                        case "No":
                                            
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
                                    Visits importInfo = new Visits();

                                    importInfo.StartDate = Convert.ToDateTime(worksheet.Cells[row, infoCursor.StartDate].Value.ToString(), dtFormat);
                                    try
                                    {
                                        importInfo.EndDate = Convert.ToDateTime(worksheet.Cells[row, infoCursor.EndDate].Value.ToString(), dtFormat);
                                    }
                                    catch
                                    {
                                        importInfo.EndDate = null;
                                    }
                                    string companyname = worksheet.Cells[row, infoCursor.Name].Value.ToString();
                                    string[] name = companyname.Split(new string[] { "Visit by " }, StringSplitOptions.RemoveEmptyEntries);
                                    companyname = "";
                                    foreach (string s in name)
                                    {
                                        companyname += s;
                                    }
                                    importInfo.Name = companyname;
                                    importInfo.Pax = int.Parse(worksheet.Cells[row, infoCursor.Pax].Value.ToString());
                                    importInfo.Host = worksheet.Cells[row, infoCursor.Host].Value.ToString();
                                    importInfo.SIC = worksheet.Cells[row, infoCursor.SIC].Value.ToString();

                                    if (worksheet.Cells[row, infoCursor.ForeignVisit].Value.ToString() == "Yes" || worksheet.Cells[row, infoCursor.ForeignVisit].Value.ToString() == "True")
                                    {
                                        importInfo.ForeignVisit = true;
                                    }
                                    else
                                    {
                                        importInfo.ForeignVisit = false;
                                    }
                                    importInfo.dateCreated = DateTime.Now;
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
            catch (Exception e)
            {

            }
            return RedirectToAction("index");
        }

        private bool Check(ImportInfoCursor infoCursor, int sumclm)
        {
            if (infoCursor.StartDate > sumclm || infoCursor.StartDate < 1)
            {
                return false;
            }
            else if (infoCursor.EndDate > sumclm || infoCursor.EndDate < 1)
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
            public int No { get; set; }
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
