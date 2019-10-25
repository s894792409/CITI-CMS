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
    public class PresetsController : ControllerBase
    {
        private readonly CMSContext _context;
        private readonly IdentityDbContext identityDbContext;
        private UserManager<AppUser> userManager;

        public PresetsController(UserManager<AppUser> userMgr)
        {
            _context = new CMSContext();
            identityDbContext = new IdentityDbContext();
            userManager = userMgr;
        }

        // GET: api/Presets
        [HttpGet]
        public async Task<IEnumerable<Preset>> GetPresetAsync()
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
                        return _context.Preset;
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        // GET: api/Presets/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPreset([FromRoute] int id)
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

                        var preset = await _context.Preset.FindAsync(id);

                        if (preset == null)
                        {
                            return NotFound();
                        }

                        return Ok(preset);
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        // PUT: api/Presets/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPreset([FromRoute] int id, [FromBody] Preset preset)
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

                        if (id != preset.presetId)
                        {
                            return BadRequest();
                        }

                        // _context.Entry(preset).State = EntityState.Modified;
                        var list = await _context.Preset.AsNoTracking().SingleAsync(s => s.presetId == id);
                        preset.presetId = id;

                        try
                        {
                            _context.Update(preset);
                            await _context.SaveChangesAsync();
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                            if (!PresetExists(id))
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

        // POST: api/Presets
        [HttpPost]
        public async Task<IActionResult> PostPreset([FromBody] Preset preset)
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
                        preset.dateCreated = DateTime.Now;
                        _context.Preset.Add(preset);
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

        // DELETE: api/Presets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePreset([FromRoute] int id)
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

                        var preset = await _context.Preset.FindAsync(id);
                        if (preset == null)
                        {
                            return NotFound();
                        }

                        _context.Preset.Remove(preset);
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

        private bool PresetExists(int id)
        {
            return _context.Preset.Any(e => e.presetId == id);
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