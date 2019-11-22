using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductRestController : ControllerBase
    {
        private CMSContext db = new CMSContext();

        [Produces("application/json")]
        [HttpGet("search")]
        public async Task<IActionResult> Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                //var names = db.Student.Where(p => p.studentName.Contains(term)).Select(p => p.studentName).ToList();
                switch (term) {
                    case "Student":
                        return Ok(db.Student.Select(p => p.studentName).ToList());
                    case "Awards":
                        return Ok(db.Awards.Select(p => p.awardName).ToList());
                    case "Preset":
                        return Ok(db.Preset.Select(p => p.presetName).ToList());
                    case "Projects":
                        return Ok(db.Projects.Select(p => p.projectName).ToList());
                    case "ShortCourses":
                        return Ok(db.ShortCourses.Select(p => p.courseName).ToList());
                    case "Theme":
                        return Ok(db.Theme.Select(p => p.themeName).ToList());
                    case "Visits":
                        return Ok(db.Visits.Select(p => p.Name).ToList());
                }
                return BadRequest();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}