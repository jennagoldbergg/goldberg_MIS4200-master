using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using goldberg_MIS4200.Models;
using System.Data.Entity;

namespace goldberg_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        
      public MIS4200Context() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, goldberg_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<Member> Member { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
   
}