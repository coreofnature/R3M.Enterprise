using R3M.Enterprise.Models.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace R3M.Enterprise.Models.DataContext
{
    public class R3M_Enterprise_DBContext : DbContext
    {
        public R3M_Enterprise_DBContext():base("R3M_Enterprise_DB")
        {

        }
        public DbSet<AboutUs> AboutUs { get; set; }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<Blog> Blog { get; set; }

        public DbSet<BlogCategory> BlogCategory{ get; set; }

        public DbSet<Contact> Contact { get; set; }

        public DbSet<GeneralSite> GeneralSite { get; set; }

        public DbSet<Services> Services { get; set; }

    }
}