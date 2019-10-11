using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using CMS.Models.ViewModels;
using System.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Collections.Generic;
using CMS.Models;

namespace CMS.Models
{
    public class CMSContext : DbContext
    {
        public DbSet<Visits> Visits { get; set; }
        public DbSet<VisitType> VisitType { get; set; }
        public DbSet<CompanyType> CompanyType { get; set; }

        //public DbSet<MediaDate> MediaDate { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer(@"Server=vaio;Database=Goldentaurus;Trusted_Connection=True;");
                IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
           
            modelBuilder.Entity<VisitType>(entity =>
            {
               
                entity.Property(e => e.visitTypeId)
                    .IsRequired();
                entity.Property(e => e.visitType)
                    .IsRequired();

            });
            modelBuilder.Entity<CompanyType>(entity =>
            {

                entity.Property(e => e.companyTypeId)
                    .IsRequired();
                entity.Property(e => e.companyType)
                    .IsRequired();

            });
        }

        public DbSet<CMS.Models.ViewModels.Preset> Preset { get; set; }

        public DbSet<CMS.Models.ViewModels.Theme> Theme { get; set; }

        public DbSet<CMS.Models.ViewModels.Student> Student { get; set; }

        public DbSet<CMS.Models.ViewModels.Projects> Projects { get; set; }

        public DbSet<CMS.Models.ViewModels.Awards> Awards { get; set; }

        public DbSet<CMS.Models.ViewModels.ShortCourses> ShortCourses { get; set; }

        public DbSet<CMS.Models.User> User { get; set; }

 
    }
}
