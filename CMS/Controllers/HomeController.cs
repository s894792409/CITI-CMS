using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using CMS.Models;
using CMS.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using CMS.Infrastructure;
using Microsoft.AspNetCore.Identity;
//https://www.free-css.com/assets/files/free-css-templates/preview/page235/words/
namespace CMS.Controllers
{
    public class HomeController : Controller
    {
        private UserManager<AppUser> userManager;
        public HomeController(UserManager<AppUser> userMgr)
        {
            userManager = userMgr;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Page(string url)
        {
            Page page = new Page();
            using (var context = new CMSContext())
            {
                page = context.Page.Where(t => t.Url == url).FirstOrDefault();
            }
            return View("Index", page);
        }

        public IActionResult ViewBlog(int id)
        {
            Blog blog = new Blog();
            using (var context = new CMSContext())
            {
                blog = context.Blog.Where(t => t.Id == id).FirstOrDefault();
                blog.PrimaryImageUrl = blog.PrimaryImageId != null ? "/" + context.Media.Where(x => x.Id == blog.PrimaryImageId).Select(x => x.Url).FirstOrDefault() : "/images/addphoto.jpg";

                ViewBag.BlogCategory = context.BlogCategory.Where(t => t.Status == true).ToList();
            }
            return View(blog);
        }


    }
}