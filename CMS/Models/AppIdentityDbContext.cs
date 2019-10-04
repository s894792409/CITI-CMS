using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CMS.Models.ViewModels;
using Microsoft.Extensions.Configuration;

namespace CMS.Models
{
    
    public class AppIdentityDbContext : IdentityDbContext<AppUser>
    {
        
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options) { }

    }
}
