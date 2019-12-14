namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Entities;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public sealed class Configuration : DbMigrationsConfiguration<DAL.AuthenticationDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(DAL.AuthenticationDB context)
        {
            //  This method will be called after migrating to the latest version.

            SeedRoles(context);
            SeedUsers(context);
        }
        string[] roles = new string[] { "Administrator", "Editor", "User" };
        void SeedRoles(AuthenticationDB context)
        {
            foreach (string role in roles)
            {

                if (!context.Roles.Any(r => r.Name == role))
                {
                    context.Roles.AddOrUpdate(new IdentityRole
                    {
                        Name = role
                    });
                }
            }
            context.SaveChanges();
        }
        void SeedUsers(AuthenticationDB context)
        {
            var pwd = new PasswordHasher();
            string hashed = pwd.HashPassword("admin@123");
            User admin = new User()
            {
                UserName = "admin",
                Email = "tientd.fis@gmail.com",
                EmailConfirmed = true,
                PhoneNumber = "+84936124031",
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                PasswordHash = hashed
            };
            if (!context.Users.Any(u => u.UserName == admin.UserName))
            {
                UserManager<User> userManager = new UserManager<User>(new UserStore<User>(context));

                userManager.Create(admin);

                foreach (string role in roles)
                {
                    if (!userManager.IsInRole(admin.Id, role))
                    {
                        userManager.AddToRole(admin.Id, role);
                    }
                }
            }
            context.SaveChanges();
        }


    }
}
