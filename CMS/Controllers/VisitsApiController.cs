using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CMS.Models;
using CMS.Models.ViewModels;

namespace CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitsApiController : ControllerBase
    {
        private readonly CMSContext _context;

        public VisitsApiController()
        {
            _context = new CMSContext();
        }

        // GET: api/VisitsApi
        [HttpGet]
        public IEnumerable<Visits> GetVisits()
        {
            return _context.Visits;
        }

        // GET: api/VisitsApi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVisits([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var visits = await _context.Visits.FindAsync(id);

            if (visits == null)
            {
                return NotFound();
            }

            return Ok(visits);
        }

        // PUT: api/VisitsApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVisits([FromRoute] int id, [FromBody] Visits visits)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != visits.visitId)
            {
                return BadRequest();
            }

            _context.Entry(visits).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VisitsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/VisitsApi
        [HttpPost]
        public async Task<IActionResult> PostVisits([FromBody] Visits visits)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Visits.Add(visits);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVisits", new { id = visits.visitId }, visits);
        }

        // DELETE: api/VisitsApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVisits([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var visits = await _context.Visits.FindAsync(id);
            if (visits == null)
            {
                return NotFound();
            }

            _context.Visits.Remove(visits);
            await _context.SaveChangesAsync();

            return Ok(visits);
        }

        private bool VisitsExists(int id)
        {
            return _context.Visits.Any(e => e.visitId == id);
        }
    }
}