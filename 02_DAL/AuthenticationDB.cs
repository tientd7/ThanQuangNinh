using DAL.Interface;
using DAL.Migrations;
using Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AuthenticationDB: IdentityDbContext<User>, IDbContext
    {
        public AuthenticationDB() : base("BasicConnect")
        {
            Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AuthenticationDB, Configuration>());
        }
        public static AuthenticationDB Create()
        {
            return new AuthenticationDB();
        }
        public DbSet<Lesson> Lessons { set; get; }
        public DbSet<Course> Courses { set; get; }
        public DbSet<Topic> Topics { set; get; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Course>().HasMany(t => t.Lessons).WithRequired(t => t.Course);
        }

    }
   

}
