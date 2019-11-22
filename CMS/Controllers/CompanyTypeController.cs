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
using System.ComponentModel.DataAnnotations;

namespace CMS.Controllers
{
    [Display(Name = "Edit company Type menu")]
    [Authorize]
    public class CompanyTypeController : Controller
    {
        private readonly CMSContext _context;

        public CompanyTypeController()
        {
            _context = new CMSContext();
        }

        // GET: CompanyType
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompanyType.ToListAsync());
        }

        // GET: CompanyType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyType = await _context.CompanyType
                .SingleOrDefaultAsync(m => m.companyTypeId == id);
            if (companyType == null)
            {
                return NotFound();
            }

            return View(companyType);
        }

        // GET: CompanyType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( CompanyType companyType2)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyType2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            return View(companyType2);
        }

        // GET: CompanyType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyType = await _context.CompanyType.SingleOrDefaultAsync(m => m.companyTypeId == id);
            if (companyType == null)
            {
                return NotFound();
            }
            return View(companyType);
        }

        // POST: CompanyType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("companyTypeId,companyType")] CompanyType companyType1)
        {
            if (id != companyType1.companyTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyType1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyTypeExists(companyType1.companyTypeId))
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
            return View(companyType1);
        }

        // GET: CompanyType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var companyType = await _context.CompanyType
                .SingleOrDefaultAsync(m => m.companyTypeId == id);
            if (companyType == null)
            {
                return NotFound();
            }

            
            return View(companyType);
        }

        // POST: CompanyType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id,string companyType)
        {
            //var Visitlist = _context.Visits.FromSql("SELECT companyTypeId, visitId, companyName, noOfPax,  FROM Visits").ToList();
            var Visitlist = await _context.Visits.ToListAsync();
           
            foreach (Visits visits in Visitlist)
            {
                //if (visits.companyTypeId == id)
                //{
                //    ViewBag.error = "This item is currently being used";
                //    CompanyType type = new CompanyType();
                //    type.companyType = companyType;
                //    type.companyTypeId = id;
                //    return View(type);
                //}
            }
            var companytype = await _context.CompanyType.SingleOrDefaultAsync(m => m.companyTypeId == id);
            _context.CompanyType.Remove(companytype);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyTypeExists(int id)
        {
            return _context.CompanyType.Any(e => e.companyTypeId == id);
        }
    }
}
