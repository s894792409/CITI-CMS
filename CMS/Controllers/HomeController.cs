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


    }
}