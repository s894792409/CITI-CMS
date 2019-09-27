using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CMS.Models;
using CMS.Models.ViewModels;

namespace CMS.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShortCoursesController : ControllerBase
    {
        private readonly CMSContext _context;

        public ShortCoursesController()
        {
            _context = new CMSContext();
        }

        // GET: api/ShortCourses
        [HttpGet]
        public IEnumerable<ShortCourses> GetShortCourses()
        {
            return _context.ShortCourses;
        }

        // GET: api/ShortCourses/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetShortCourses([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var shortCourses = await _context.ShortCourses.FindAsync(id);

            if (shortCourses == null)
            {
                return NotFound();
            }

            return Ok(shortCourses);
        }

        // PUT: api/ShortCourses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShortCourses([FromRoute] int id, [FromBody] ShortCourses shortCourses)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != shortCourses.courseId)
            {
                return BadRequest();
            }

            // _context.Entry(shortCourses).State = EntityState.Modified;
            var list = await _context.ShortCourses.AsNoTracking().SingleAsync(s => s.courseId == id);
            shortCourses.dateCreated = list.dateCreated;
            shortCourses.courseId = id;

            try
            {
                _context.Update(shortCourses);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShortCoursesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            APIReturn re = new APIReturn();
            re.Status = "success";
            return Ok(re);
        }

        // POST: api/ShortCourses
        [HttpPost]
        public async Task<IActionResult> PostShortCourses([FromBody] ShortCourses shortCourses)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            shortCourses.dateCreated = DateTime.Now;
            _context.ShortCourses.Add(shortCourses);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetShortCourses", new { id = shortCourses.courseId }, shortCourses);
            APIReturn re = new APIReturn();
            re.Status = "success";
            return Ok(re);
        }

        // DELETE: api/ShortCourses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShortCourses([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var shortCourses = await _context.ShortCourses.FindAsync(id);
            if (shortCourses == null)
            {
                return NotFound();
            }

            _context.ShortCourses.Remove(shortCourses);
            await _context.SaveChangesAsync();

            // return Ok(shortCourses);
            APIReturn re = new APIReturn();
            re.Status = "success";
            return Ok(re);
        }

        private bool ShortCoursesExists(int id)
        {
            return _context.ShortCourses.Any(e => e.courseId == id);
        }
    }
}