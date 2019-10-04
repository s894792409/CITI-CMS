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

namespace CMS.Controllers
{
    [Authorize]
    public class ThemesController : Controller
    {
        private readonly CMSContext _context;

        public ThemesController()
        {
            _context = new CMSContext();
        }

        // GET: Themes
        public async Task<IActionResult> Index()
        {var list = await _context.Theme.ToListAsync();
            return View(await _context.Theme.ToListAsync());
        }

        // GET: Themes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theme = await _context.Theme
                .SingleOrDefaultAsync(m => m.themeId == id);
            if (theme == null)
            {
                return NotFound();
            }

            return View(theme);
        }

        // GET: Themes/Create
        public IActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/AfterLogin
        public ActionResult QueryTheme(Preset model)
        {
            Theme theme = new Theme();
            var list = from m in _context.Theme
                       select m;




            // return View("ViewTheme",list.ToList());
            return View();
        }

        public ActionResult QueryTheme()
        {
            return QueryTheme(TempData["model"] as Preset);
        }

        // POST: Themes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("themeId,themeName,dateCreated,backgroundColor,fontStyle")] Theme theme)
        {
            if (ModelState.IsValid)
            {
                theme.dateCreated = DateTime.Now;
                _context.Add(theme);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(theme);
        }

        // GET: Themes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theme = await _context.Theme.SingleOrDefaultAsync(m => m.themeId == id);
            if (theme == null)
            {
                return NotFound();
            }
            return View(theme);
        }

        // POST: Themes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("themeId,themeName,backgroundColor,fontStyle")] Theme theme)
        {
            if (id != theme.themeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                  
                    _context.Update(theme);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThemeExists(theme.themeId))
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
            return View(theme);
        }

        // GET: Themes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theme = await _context.Theme
                .SingleOrDefaultAsync(m => m.themeId == id);
            if (theme == null)
            {
                return NotFound();
            }

            return View(theme);
        }

        // POST: Themes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var use =   _context.Preset.AsNoTracking().Where(s=>s.themeId==id);
            if (use != null) {
                ViewBag.error= "This item is currently being used";
                var theme1 = await _context.Theme.SingleOrDefaultAsync(m => m.themeId == id);
                return View(theme1);
            }
            
            var theme = await _context.Theme.SingleOrDefaultAsync(m => m.themeId == id);
            _context.Theme.Remove(theme);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
               public async Task<IActionResult> ViewTheme(int themeId)
        {
            var theme = await _context.Theme.SingleOrDefaultAsync(s=>s.themeId==themeId);

            return View(theme);
        }
        private bool ThemeExists(int id)
        {
            return _context.Theme.Any(e => e.themeId == id);
        }
    }
}
