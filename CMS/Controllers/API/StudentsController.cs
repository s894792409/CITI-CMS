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
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Formats;

namespace CMS.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly CMSContext _context;
        private readonly IdentityDbContext identityDbContext;
        private UserManager<AppUser> userManager;

        public StudentsController(UserManager<AppUser>userMgr)
        {
            _context = new CMSContext();
            identityDbContext = new IdentityDbContext();
            userManager = userMgr;
        }

        // GET: api/Students
        [HttpGet]
        public async Task<IActionResult> GetStudentAsync()
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
                        var stulist =await  _context.Student.ToListAsync();
                        List<StudentInfo> studentInfos = new List<StudentInfo>();
                        foreach (Student stu in stulist)
                        {
                            // MemoryStream ms = new MemoryStream(stu.Photo);
                            IImageFormat format;
                            Image<Rgba64> image = Image.Load<Rgba64>(stu.Photo, out format);
                            var str = image.ToBase64String(format);
                            StudentInfo info = new StudentInfo();
                            info.dateCreated = stu.dateCreated;
                            info.photo = str;
                            info.projectId = stu.projectId;
                            info.studentAdmin = stu.studentAdmin;
                            info.studentBirthday = stu.studentBirthday;
                            info.studentName = stu.studentName;
                            info.studentPortfolio = stu.studentPortfolio;
                            studentInfos.Add(info);
                        }
                        return Ok(studentInfos);
                    }
                }
                return BadRequest();
            }
            catch
            {
                return BadRequest();
            }
            
        }

        // GET: api/Students/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent([FromRoute] string id)
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

                        var student = await _context.Student.FindAsync(id);
                        IImageFormat format;
                        Image<Rgba64> image = Image.Load<Rgba64>(student.Photo, out format);
                        var str = image.ToBase64String(format);
                        StudentInfo info = new StudentInfo();
                        info.dateCreated = student.dateCreated;
                        info.photo = str;
                        info.projectId = student.projectId;
                        info.studentAdmin = student.studentAdmin;
                        info.studentBirthday = student.studentBirthday;
                        info.studentName = student.studentName;
                        info.studentPortfolio = student.studentPortfolio;

                        if (student == null)
                        {
                            return NotFound();
                        }
                        
                        return Ok(info);
                    }
                }
                return BadRequest();
            }
            catch {
                return BadRequest();
            }

            
        }

        //// PUT: api/Students/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutStudent([FromRoute] string id, [FromBody] Student student)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != student.studentAdmin)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(student).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!StudentExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Students
        //[HttpPost]
        //public async Task<IActionResult> PostStudent([FromBody] Student student)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Student.Add(student);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetStudent", new { id = student.studentAdmin }, student);
        //}

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var student = await _context.Student.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            _context.Student.Remove(student);
            await _context.SaveChangesAsync();

            return Ok(student);
        }

        private bool StudentExists(string id)
        {
            return _context.Student.Any(e => e.studentAdmin == id);
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

        public class StudentInfo {
            public string photo { get; set; }
            public string studentAdmin { get; set; }
            public string studentName { get; set; }
            public int projectId { get; set; }
            public DateTime studentBirthday { get; set; }

            public DateTime dateCreated { get; set; }
            public string studentPortfolio { get; set; }
        }
    }
}