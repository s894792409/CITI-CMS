using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CMS.Models;
using CMS.Models.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace CMS.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly CMSContext _context;
        private readonly IdentityDbContext identityDbContext;
        private UserManager<AppUser> userManager;
        public ProjectsController(UserManager<AppUser> userMgr)
        {
            _context = new CMSContext();
            identityDbContext = new IdentityDbContext();
            userManager = userMgr;
        }

        // GET: api/Projects
        [HttpGet]
        public async Task<IEnumerable<Projects>> GetProjectsAsync()
        {
            
            try
            {
                string key = HttpContext.Request.Headers["Key"];
                if (key != null)
                {
                    UserInfo userInfo = identityDbContext.AspNetUsers.Single(s => s.UserKey == key);
                    if (userInfo != null)
                    {
                        await RefreshAsync(userInfo);
                        return _context.Projects;
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        // GET: api/Projects/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProjects([FromRoute] int id)
        {
            
            try
            {
                string key = HttpContext.Request.Headers["Key"];
                if (key != null)
                {
                    UserInfo userInfo = identityDbContext.AspNetUsers.Single(s => s.UserKey == key);
                    if (userInfo != null)
                    {
                        if (!ModelState.IsValid)
                        {
                            return BadRequest(ModelState);
                        }

                        var projects = await _context.Projects.FindAsync(id);

                        if (projects == null)
                        {
                            return NotFound();
                        }
                        await RefreshAsync(userInfo);
                        return Ok(projects);
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        // PUT: api/Projects/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProjects([FromRoute] int id, [FromBody] Projects projects)
        {
            
            try
            {
                string key = HttpContext.Request.Headers["Key"];
                if (key != null)
                {
                    UserInfo userInfo = identityDbContext.AspNetUsers.Single(s => s.UserKey == key);
                    if (userInfo != null)
                    {
                        if (!ModelState.IsValid)
                        {
                            return BadRequest(ModelState);
                        }

                        if (id != projects.projectId)
                        {
                            return BadRequest();
                        }

                        _context.Entry(projects).State = EntityState.Modified;

                        try
                        {
                            await RefreshAsync(userInfo);
                            await _context.SaveChangesAsync();
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                            if (!ProjectsExists(id))
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
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        // POST: api/Projects
        [HttpPost]
        public async Task<IActionResult> PostProjects([FromBody] Projects projects)
        {
            
            try
            {
                string key = HttpContext.Request.Headers["Key"];
                if (key != null)
                {
                    UserInfo userInfo = identityDbContext.AspNetUsers.Single(s => s.UserKey == key);
                    if (userInfo != null)
                    {
                        await RefreshAsync(userInfo);
                        if (!ModelState.IsValid)
                        {
                            return BadRequest(ModelState);
                        }
                        projects.dateCreated = DateTime.Now;
                        _context.Projects.Add(projects);
                        await _context.SaveChangesAsync();

                        return CreatedAtAction("GetProjects", new { id = projects.projectId }, projects);
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        // DELETE: api/Projects/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProjects([FromRoute] int id)
        {
            
            try
            {
                string key = HttpContext.Request.Headers["Key"];
                if (key != null)
                {
                    UserInfo userInfo = identityDbContext.AspNetUsers.Single(s => s.UserKey == key);
                    if (userInfo != null)
                    {
                        await RefreshAsync(userInfo);
                        if (!ModelState.IsValid)
                        {
                            return BadRequest(ModelState);
                        }

                        var projects = await _context.Projects.FindAsync(id);
                        if (projects == null)
                        {
                            return NotFound();
                        }

                        _context.Projects.Remove(projects);
                        await _context.SaveChangesAsync();

                        return Ok(projects);
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        private bool ProjectsExists(int id)
        {
            return _context.Projects.Any(e => e.projectId == id);
        }

        private static string MakeKey(int pwdLength)

        {     //声明要返回的字符串    

            string tmpstr = "";

            //密码中包含的字符数组    

            string pwdchars = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()_?/-=";

            //数组索引随机数    

            int iRandNum;

            //随机数生成器    

            Random rnd = new Random();

            for (int i = 0; i < pwdLength; i++)

            {      //Random类的Next方法生成一个指定范围的随机数     

                iRandNum = rnd.Next(pwdchars.Length);

                //tmpstr随机添加一个字符     

                tmpstr += pwdchars[iRandNum];

            }

            return tmpstr;
        }

        public async Task RefreshAsync(UserInfo userInfo)
        {
            AppUser user = await userManager.FindByNameAsync(userInfo.UserName);
            user.UserKey = MakeKey(15);
            IdentityResult result2 = await userManager.UpdateAsync(user);
        }
    }
}