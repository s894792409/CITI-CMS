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
    public class ThemesController : ControllerBase
    {
        private readonly CMSContext _context;
        private readonly IdentityDbContext identityDbContext;
        private UserManager<AppUser> userManager;
        public ThemesController(UserManager<AppUser> userMgr)
        {
            _context = new CMSContext();
            userManager = userMgr;
            identityDbContext = new IdentityDbContext();
        }

        // GET: api/Themes
        [HttpGet]
        public async Task<IEnumerable<Theme>> GetThemeAsync()
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
                        return _context.Theme;
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        //GET: api/Themes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTheme([FromRoute] int id)
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

                        var theme = await _context.Theme.FindAsync(id);

                        if (theme == null)
                        {
                            return NotFound();
                        }

                        return Ok(theme);
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        // PUT: api/Themes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTheme([FromRoute] int id, [FromBody] Theme theme)
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

                        if (id != theme.themeId)
                        {
                            return BadRequest();
                        }

                        _context.Entry(theme).State = EntityState.Modified;

                        try
                        {
                            await _context.SaveChangesAsync();
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                            if (!ThemeExists(id))
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
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        // POST: api/Themes
        [HttpPost]
        public async Task<IActionResult> PostTheme([FromBody] Theme theme)
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
                        theme.dateCreated = DateTime.Now;
                        _context.Theme.Add(theme);
                        await _context.SaveChangesAsync();

                        APIReturn re = new APIReturn();
                        re.Status = "success";
                        return Ok(re);
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        // DELETE: api/Themes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTheme([FromRoute] int id)
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

                        var theme = await _context.Theme.FindAsync(id);
                        if (theme == null)
                        {
                            return NotFound();
                        }

                        _context.Theme.Remove(theme);
                        await _context.SaveChangesAsync();

                        APIReturn re = new APIReturn();
                        re.Status = "success";
                        return Ok(re);
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        private bool ThemeExists(int id)
        {
            return _context.Theme.Any(e => e.themeId == id);
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