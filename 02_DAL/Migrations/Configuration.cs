namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Entities;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.AuthenticationDB>
    {
        public static bool isInitDB = false;
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
        string[] roles = new string[] { "Owner", "Administrator", "Manager", "Editor" };
        private void SeedRoles(AuthenticationDB context)
        {
            //if (!isInitDB)
            //    return;

            foreach (string role in roles)
            {
                RoleStore<Role> roleStore = new RoleStore<Role>(context);

                if (!context.Roles.Any(r => r.Name == role))
                {
                    roleStore.CreateAsync(new Role(role));
                }
            }
        }
        private void SeedUsers(AuthenticationDB context)
        {
            //if (!isInitDB)
            //    return;

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
        }
    }
}
