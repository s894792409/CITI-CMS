using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using CMS.Models;
using CMS.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace CMS.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllController : ControllerBase
    {
        private readonly CMSContext _context;
        private readonly IdentityDbContext identityDbContext;
        private UserManager<AppUser> userManager;


        public GetAllController(UserManager<AppUser> userMgr)
        {
            _context = new CMSContext();
            identityDbContext = new IdentityDbContext();
            userManager = userMgr;
        }
        // GET: api/GetAll
        [HttpGet]
        public async Task<IActionResult> GetAsync()
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
                        Sum sum = new Sum();
                        int NoOfVisit = 0, NoOfProjects = 0, NoOfShortcourses = 0, NoOfAward = 0;
                        var list = _context.Visits.AsNoTracking().ToList();
                        foreach (Visits visits in list)
                        {
                            NoOfVisit++;
                        }
                        var list2 = _context.Projects.AsNoTracking().ToList();
                        foreach (Projects visits in list2)
                        {
                            NoOfProjects++;
                        }
                        var list3 = _context.ShortCourses.AsNoTracking().ToList();
                        foreach (ShortCourses visits in list3)
                        {
                            NoOfShortcourses++;
                        }
                        var list4 = _context.Awards.AsNoTracking().ToList();
                        foreach (Awards visits in list4)
                        {
                            NoOfAward++;
                        }

                        sum.AwardsSum = NoOfAward;
                        sum.ShortCoursesSum = NoOfShortcourses;
                        sum.ProjectsSum = NoOfProjects;
                        sum.VisitsSum = NoOfVisit;

                        var presetlist = await _context.Preset.AsNoTracking().ToListAsync();
                        var boxlist = await _context.Box.AsNoTracking().ToListAsync();
                        var cardlist = await _context.Card.AsNoTracking().ToListAsync();
                        List<IOformat> ioformatlist = new List<IOformat>();
                        foreach (Preset p in presetlist)
                        {
                            IOformat ioformat = new IOformat();
                            ioformat.presetId = p.presetId;
                            ioformat.presetName = p.presetName;
                            ioformat.themeId = p.themeId;
                            ioformat.visitId = p.visitId;
                            ioformat.dateCreated = p.dateCreated;
                            try
                            {
                                List<Boxformat> boxformatlist = new List<Boxformat>();
                                foreach (Box box in boxlist.Where(b => b.presetId == p.presetId))
                                {
                                    Boxformat boxformat = new Boxformat();
                                    boxformat.boxId = box.boxId;
                                    boxformat.cardList = cardlist.Where(c => c.boxId == box.boxId).ToList();
                                    boxformatlist.Add(boxformat);
                                }
                                ioformat.presetBoxList = boxformatlist;

                            }
                            catch
                            {
                            }
                            ioformatlist.Add(ioformat);
                        }
                       
                        All all = new All();
                        all.Visits = _context.Visits;
                        all.Awards = _context.Awards;
                        all.Presets = ioformatlist;
                        all.Projects = _context.Projects;
                        all.ShortCourses = _context.ShortCourses;
                        all.Sum = sum;
                        return Ok(all);
                    }
                }
            }
            catch
            {
                return BadRequest();
            }
            return BadRequest();

        }


        public class All {
            public DbSet<Visits> Visits { get; set; }
            public DbSet<Awards> Awards { get; set; }
            public DbSet<Projects> Projects { get; set; }
            public List<IOformat> Presets { get; set; }
            public DbSet<ShortCourses> ShortCourses { get; set; }
            public Sum Sum { get; set; }
        }
        public class IOformat
        {
            public int presetId { get; set; }
            public int themeId { get; set; }
            public int visitId { get; set; }
            public string presetName { get; set; }
            public DateTime dateCreated { get; set; }
            public List<Boxformat> presetBoxList { get; set; }
        }
        public class Boxformat
        {
            public int boxId { get; set; }
            public List<Card> cardList { get; set; }
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

