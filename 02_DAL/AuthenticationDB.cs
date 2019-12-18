using DAL.Interface;
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
        public AuthenticationDB() : base("AuthenConnect")
        {
            Configuration.ProxyCreationEnabled = false;
        }
        public static AuthenticationDB Create()
        {
            return new AuthenticationDB();
        }
        

    }
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("BasicConnect") { }
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
