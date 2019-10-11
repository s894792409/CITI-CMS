using CMS.Infrastructure;
using CMS.Models;
using CMS.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CMS.Components
{
    public class SiteInfo : ViewComponent
    {
        private IHostingEnvironment hostingEnvironment;

        public SiteInfo(IHostingEnvironment environment)
        {
            hostingEnvironment = environment;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }

    }

    public class SiteMenu : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }

        string CreateMenuItem(MenuJsonChild child)
        {
            string childString = "<li><a href=\"" + child.slug + "\">" + child.name + "</a></li>";
            return childString;
        }
    }
}
