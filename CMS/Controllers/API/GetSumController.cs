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
    public class GetSumController : ControllerBase
    {
        private readonly CMSContext context;
        private Sum sum = new Sum();

        public GetSumController()
        {
            context = new CMSContext();
            int NoOfVisit = 0, NoOfProjects = 0, NoOfShortcourses = 0, NoOfAward = 0;
            var list = context.Visits.AsNoTracking().ToList();
            foreach (Visits visits in list)
            {
                NoOfVisit++;
            }
            var list2 =  context.Projects.AsNoTracking().ToList();
            foreach (Projects visits in list2)
            {
                NoOfProjects++;
            }
            var list3 =  context.ShortCourses.AsNoTracking().ToList();
            foreach (ShortCourses visits in list3)
            {
                NoOfShortcourses++;
            }
            var list4 =  context.Awards.AsNoTracking().ToList();
            foreach (Awards visits in list4)
            {
                NoOfAward++;
            }

            sum.AwardsSum = NoOfAward;
            sum.ShortCoursesSum = NoOfShortcourses;
            sum.ProjectsSum = NoOfProjects;
            sum.VisitsSum = NoOfVisit;
        }
        // GET: api/GetSum
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            
            return Ok(sum);
        }

        // GET: api/GetSum/VisitsSum
        [HttpGet("{name}", Name = "Get")]
        public IActionResult Get(string name)
        {
            if (name == "VisitsSum") {
                VisitSum visitSum = new VisitSum();
                visitSum.VisitsSum = sum.VisitsSum;
                return Ok(visitSum);
            }else if (name == "ProjectsSum") {
                ProjectSum projectSum = new ProjectSum();
                projectSum.ProjectsSum = sum.ProjectsSum;
                return Ok(projectSum);
            }
            else if (name == "ShortCoursesSum")
            {
                ShortCoursSum shortCoursSum = new ShortCoursSum();
                shortCoursSum.ShortCoursesSum = sum.ShortCoursesSum;
                return Ok(shortCoursSum);
            }
            else if (name == "AwardsSum")
            {
                AwardSum awardSum = new AwardSum();
                awardSum.AwardsSum = sum.AwardsSum;
                return Ok(awardSum);
            }
            return BadRequest();
        }
        public class AwardSum {
            public int AwardsSum { get; set; }
        }
        public class ShortCoursSum
        {
            public int ShortCoursesSum { get; set; }
        }
        public class ProjectSum
        {
            public int ProjectsSum { get; set; }
        }
        public class VisitSum
        {
            public int VisitsSum { get; set; }
        }
        // POST: api/GetSum
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/GetSum/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
