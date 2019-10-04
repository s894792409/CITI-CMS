using CMS.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Models;

namespace CMS.Models
{
    public class IdentityDbContext: DbContext
    {
        public DbSet<RoleModification> AspNetRoles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer(@"Server=vaio;Database=Goldentaurus;Trusted_Connection=True;");
                IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(configuration["ConnectionStrings:IdentityConnection"]);
            }
        }
        public DbSet<CMS.Models.ViewModels.UserInfo> AspNetUsers { get; set; }
    }
}
