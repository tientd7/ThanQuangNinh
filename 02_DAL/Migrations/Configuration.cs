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
        public static bool isInitDb = false;
        protected override void Seed(DAL.AuthenticationDB context)
        {
            //  This method will be called after migrating to the latest version.
            
            SeedRoles(context);
            SeedUsers(context);
            isInitDb = false;
        }
        string[] roles = new string[] { "Owner", "Administrator", "Manager", "Editor" };
        void SeedRoles(AuthenticationDB context)
        {
            if (!isInitDb)
                return;

            foreach (string role in roles)
            {

                if (!context.Roles.Any(r => r.Name == role))
                {
                    context.Roles.AddOrUpdate(new Role
                    {
                        Name = role,
                        Enable = true
                    });
                }
            }
            context.SaveChanges();
        }
        void SeedUsers(AuthenticationDB context)
        {
            if (!isInitDb)
                return;

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
                var userStore = new UserStore<User>(context);
                var result = userStore.CreateAsync(admin);
                foreach (string role in roles)
                {
                    userStore.AddToRoleAsync(admin, role);
                }
            }
            context.SaveChanges();
        }
    }
}
