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
using Microsoft.AspNetCore.Http;
using System.IO;
using Newtonsoft.Json;
using ImageTest.Models;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.Primitives;
using SixLabors.ImageSharp.Processing;
using Microsoft.AspNetCore.Hosting;

namespace CMS.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {
        private readonly CMSContext _context;
        private IHostingEnvironment _hostingEnvironment;
        public StudentsController(IHostingEnvironment hostingEnvironment)
        {
            _context = new CMSContext();
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            ViewBag.rows = 5;
            return View(await _context.Student.ToListAsync());
        }

        
        public IActionResult QueryView()
        {
            return View();
        }
        public async Task<IActionResult> QueryStudent(Student student)
        {
            var list = from m in _context.Student
                        select m;

            if (!String.IsNullOrEmpty(student.studentName))
            {
                list = list.Where(s => s.studentName.Contains(student.studentName));
            }

            return View(await list.ToListAsync());
        }
        // GET: Students/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .SingleOrDefaultAsync(m => m.studentAdmin == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            var projectlist = _context.Projects.ToList();
            var projectSelect = new SelectList(projectlist, "projectId", "projectName");
            ViewBag.projectselect = projectSelect;
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("studentAdmin,studentName,projectId,studentYear")] Student student,IFormFile imagefile, string  tailor)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //try
        //        //{var file = HttpContext.Request.Form.Files["txt_file"];
        //        //    IFormFile uploadfile = imagefile;
        //        //    return Content(uploadfile.FileName + uploadfile.Name);
        //        //}
        //        //catch (Exception e) {

        //        //    return Content(e.Message+"/n" + e.StackTrace);
        //        //}

        //        var tailorInfoEntity = JsonConvert.DeserializeObject<TailorInfo>(tailor);
        //        var check = await _context.Student.SingleOrDefaultAsync(s => s.studentAdmin == student.studentAdmin);
        //        if (check == null)
        //        {
        //            string webrootpath = _hostingEnvironment.WebRootPath;
        //            string filename = $"{ Guid.NewGuid()}.png";
        //            string path = Path.Combine(webrootpath, filename).ToString();
        //            using (Image<Rgba64> image = Image.Load<Rgba64>(imagefile.OpenReadStream()))
        //            {
        //                Rectangle rectangle = new Rectangle(tailorInfoEntity.CoordinateX, tailorInfoEntity.CoordinateY, tailorInfoEntity.CoordinateWidth, tailorInfoEntity.CoordinateHeight);
        //                image.Mutate(x => x
        //                     .Crop(rectangle)
        //                     .Resize(tailorInfoEntity.CoordinateWidth, tailorInfoEntity.CoordinateHeight)
        //                     );
        //                image.Save(path);
        //                FileStream fs = new FileStream(path, FileMode.Open);
        //                //Stream stream = fs as Stream;
        //                MemoryStream memory = new MemoryStream();
        //                fs.CopyTo(memory);
        //                student.Photo = memory.ToArray();
        //                student.PhotoType = imagefile.ContentType;
        //            };
        //            //FileInfo file = new FileInfo(path);

        //            //if (uploadfile == null || uploadfile.ContentType.ToLower().StartsWith("image/")) {
        //            //    MemoryStream ms = new MemoryStream();
        //            //    uploadfile.OpenReadStream().CopyTo(ms);
        //            //    System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
        //            //    student.Photo = ms.ToArray();
        //            //    student.PhotoType = uploadfile.ContentType;
        //            //}
        //            student.dateCreated = DateTime.Now;
        //            _context.Add(student);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }
        //        else {
        //            ViewBag.error = "The student Admin already exists!";
        //            var projectlist = _context.Projects.ToList();
        //            var projectSelect = new SelectList(projectlist, "projectId", "projectName");
        //            ViewBag.projectselect = projectSelect;
        //            return View();
        //        }

        //    }
        //    return View(student);
        //}

        [HttpPost]
        public async Task<IActionResult> CreateData()
        {

            bool success = false;
            var files = Request.Form.Files;
            var file = files.FirstOrDefault();
            string msg = Request.Form["tailorInfo"];
            var tailorInfoEntity = JsonConvert.DeserializeObject<TailorInfo>(msg);
            string stuinfo = Request.Form["stuinfo"];
            var student = JsonConvert.DeserializeObject<Student>(stuinfo);
            try
            {
                var check = await _context.Student.SingleOrDefaultAsync(s => s.studentAdmin == student.studentAdmin);
                if (check == null)
                {
                    try
                    {
                        string webrootpath = _hostingEnvironment.WebRootPath;
                        string filename = $"{ Guid.NewGuid()}.png";
                        string path = Path.Combine(webrootpath, filename).ToString();
                        Image<Rgba64> image = Image.Load<Rgba64>(file.OpenReadStream());
                        
                            Rectangle rectangle = new Rectangle(tailorInfoEntity.CoordinateX, tailorInfoEntity.CoordinateY, tailorInfoEntity.CoordinateWidth, tailorInfoEntity.CoordinateHeight);
                            image.Mutate(x => x
                                 .Crop(rectangle)
                                 .Resize(tailorInfoEntity.CoordinateWidth, tailorInfoEntity.CoordinateHeight)
                                 );
                            image.Save(path);
                            FileStream fs = new FileStream(path, FileMode.Open);
                            MemoryStream memory = new MemoryStream();
                            fs.CopyTo(memory);
                            student.Photo = memory.ToArray();
                            student.PhotoType = file.ContentType;
                            fs.Close();
                        
                        FileInfo fileInfo = new FileInfo(Path.Combine(path));
                        fileInfo.Delete();
                        student.dateCreated = DateTime.Now;
                        _context.Add(student);
                        await _context.SaveChangesAsync();
                        success = true;
                    }
                    catch (Exception e)
                    {
                        msg = e.Message;
                    }
                }
                else
                {
                    msg = "The student Admin already exists!";
                }
            }
            catch (Exception e) {
                msg = e.Message;
            }
            
            return Json(new { success = success.ToString(),msg=msg });
        }

        [HttpPost]
        public async Task<IActionResult> UpdateData()
        {
            bool success = false;
            var files = Request.Form.Files;
            var file = files.FirstOrDefault();
            string msg = Request.Form["tailorInfo"];
            var tailorInfoEntity = JsonConvert.DeserializeObject<TailorInfo>(msg);
            string stuinfo = Request.Form["stuinfo"];
            var student = JsonConvert.DeserializeObject<Student>(stuinfo);
            var stu = _context.Student.AsNoTracking().SingleOrDefault(s => s.studentAdmin == student.studentAdmin);
            if (stu != null)
            {
                try
                {
                    if (file != null)
                    {
                        try
                        {
                            string webrootpath = _hostingEnvironment.WebRootPath;
                            string filename = $"{ Guid.NewGuid()}.png";
                            string path = Path.Combine(webrootpath, filename).ToString();
                            using (Image<Rgba64> image = Image.Load<Rgba64>(file.OpenReadStream()))
                            {
                                Rectangle rectangle = new Rectangle(tailorInfoEntity.CoordinateX, tailorInfoEntity.CoordinateY, tailorInfoEntity.CoordinateWidth, tailorInfoEntity.CoordinateHeight);
                                image.Mutate(x => x
                                     .Crop(rectangle)
                                     .Resize(tailorInfoEntity.CoordinateWidth, tailorInfoEntity.CoordinateHeight)
                                     );
                                image.Save(path);
                                FileStream fs = new FileStream(path, FileMode.Open);
                                //Stream stream = fs as Stream;
                                MemoryStream memory = new MemoryStream();
                                fs.CopyTo(memory);
                                student.Photo = memory.ToArray();
                                student.PhotoType = file.ContentType;
                            };
                            FileInfo fileInfo = new FileInfo(Path.Combine(path));
                            fileInfo.Delete();
                        }
                        catch (Exception e)
                        {
                            msg = e.Message;
                        }
                    }
                    else
                    {
                        student.Photo = stu.Photo;
                        student.PhotoType = stu.PhotoType;
                    }
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                    success = true;
                }
                catch (Exception e) {
                    msg=e.Message;
                }
            }
            else {
                msg = "Not found";
            }
            return Json(new { success = success.ToString(),msg=msg });
        }

        [HttpPost]
        public ActionResult UpLoadFile(string tailorInfo)
        {
            var success = false;
            var message = string.Empty;
            var newImage = string.Empty;
            var pictureUrl = string.Empty;
            try
            {
                var tailorInfoEntity = JsonConvert.DeserializeObject<TailorInfo>(tailorInfo);
                tailorInfoEntity.PictureWidth = tailorInfoEntity.PictureWidth.Replace("px", "");
                tailorInfoEntity.PictureHeight = tailorInfoEntity.PictureHeight.Replace("px", "");
                var file = HttpContext.Request.Form.Files["txt_file"];
                
                if (file != null && file.Length != 0)
                {
                    newImage = ImageCompress(file.OpenReadStream(), tailorInfoEntity);
                    success = true;
                    message = "保存成功";
                }
            }
            catch (Exception ex)
            {
                message = "保存失败 " + ex.Message + "   " + ex.StackTrace.ToString();
            }
            return Json(new { success = success, message = message, newImage = newImage });

        }
        public static string ImageCompress(Stream content,TailorInfo tailorInfo)
        {
            IImageFormat format;
            var imageString = string.Empty;
            using (Image<Rgba64> image = Image.Load<Rgba64>(content, out format))
            {
                Rectangle rectangle = new Rectangle(tailorInfo.CoordinateX, tailorInfo.CoordinateY, tailorInfo.CoordinateWidth, tailorInfo.CoordinateHeight);
                image.Mutate(x => x
                     .Crop(rectangle)
                     .Resize(tailorInfo.CoordinateWidth, tailorInfo.CoordinateHeight)
                     );
                

                imageString = image.ToBase64String<Rgba64>(format);
            }
            return imageString;
        }
        [HttpGet]
        public IActionResult ViewPhoto(string studentadmin) {
           // return Content("studentAdmin:"+studentadmin +" end");
            Student student= _context.Student.SingleOrDefault(s => s.studentAdmin == studentadmin);
            MemoryStream ms = new MemoryStream(student.Photo);
            return new FileStreamResult(ms, student.PhotoType);
        }
        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.SingleOrDefaultAsync(m => m.studentAdmin == id);
            if (student == null)
            {
                return NotFound();
            }
            var projectlist = _context.Projects.ToList();
            var projectSelect = new SelectList(projectlist, "projectId", "projectName");
            ViewBag.projectselect = projectSelect;
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("studentAdmin,studentName,projectId,studentYear,dateCreated")] Student student)
        {
            if (id != student.studentAdmin)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var stu = _context.Student.AsNoTracking().SingleOrDefault(s => s.studentAdmin == student.studentAdmin);
                    student.Photo = stu.Photo;
                    student.PhotoType = stu.PhotoType;
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.studentAdmin))
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
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .SingleOrDefaultAsync(m => m.studentAdmin == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var student = await _context.Student.SingleOrDefaultAsync(m => m.studentAdmin == id);
            _context.Student.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(string id)
        {
            return _context.Student.Any(e => e.studentAdmin == id);
        }
    }
}
