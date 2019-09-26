﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CMS.Models;
using CMS.Models.ViewModels;

namespace CMS.Controllers
{
    public class PresetsController : Controller
    {
        private readonly CMSContext _context;

        public PresetsController()
        {
            _context = new CMSContext();
        }

        // GET: Presets
        public async Task<IActionResult> Index()
        {
            return View(await _context.Preset.ToListAsync());
        }
        public ActionResult QueryTheme(int? id) {
            Preset preset = new Preset();
            preset.themeId = (int)id;
            TempData["model"] = preset;
            return RedirectToAction("Themes", "QueryTheme");
        }
        
        // GET: Presets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preset = await _context.Preset
                .SingleOrDefaultAsync(m => m.presetId == id);
            if (preset == null)
            {
                return NotFound();
            }

            return View(preset);
        }

        // GET: Presets/Create
        public IActionResult Create()
        {
            var list = _context.Visits.ToList();
            var selectlist = new SelectList(list, "visitId", "companyName");
            ViewBag.selectlist = selectlist;
            var themelist = _context.Theme.ToList();
            var namelist = new SelectList(themelist, "themeId", "themeName");
            ViewBag.namelist = namelist;
            return View();
        }

        // POST: Presets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("presetId,themeId,visitId")] Preset preset)
        {
            if (ModelState.IsValid)
            {
                preset.dateCreated = DateTime.Now;
                _context.Add(preset);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            var list = _context.Visits.ToList();
            var selectlist = new SelectList(list, "visitId", "companyName");
            ViewBag.selectlist = selectlist;
            var themelist = _context.Theme.ToList();
            var namelist = new SelectList(themelist, "themeId", "themeName");
            ViewBag.namelist = namelist;
            return View(preset);
        }

        // GET: Presets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preset = await _context.Preset.SingleOrDefaultAsync(m => m.presetId == id);
            if (preset == null)
            {
                return NotFound();
            }
            var list = _context.Visits.ToList();
            var selectlist = new SelectList(list, "visitId", "companyName");
            ViewBag.selectlist = selectlist;
            var themelist = _context.Theme.ToList();
            var namelist = new SelectList(themelist, "themeId", "themeName");
            ViewBag.namelist = namelist;
            return View(preset);
        }

        // POST: Presets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("presetId,dateCreated,themeId,visitId")] Preset preset)
        {
            if (id != preset.presetId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(preset);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PresetExists(preset.presetId))
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
            var list = _context.Visits.ToList();
            var selectlist = new SelectList(list, "visitId", "companyName");
            ViewBag.selectlist = selectlist;
            var themelist = _context.Theme.ToList();
            var namelist = new SelectList(themelist, "themeId", "themeName");
            ViewBag.namelist = namelist;
            return View(preset);
        }

        // GET: Presets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preset = await _context.Preset
                .SingleOrDefaultAsync(m => m.presetId == id);
            if (preset == null)
            {
                return NotFound();
            }

            return View(preset);
        }

        // POST: Presets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var preset = await _context.Preset.SingleOrDefaultAsync(m => m.presetId == id);
            _context.Preset.Remove(preset);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PresetExists(int id)
        {
            return _context.Preset.Any(e => e.presetId == id);
        }
    }
}
