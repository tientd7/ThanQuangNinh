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
    public class AuthenticationDB: IdentityDbContext<User,Role,string,IdentityUserLogin,IdentityUserRole,IdentityUserClaim>,IDbContext
    {
        public AuthenticationDB() : base("BasicConnect")
        {
            Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AuthenticationDB, Configuration>());
        }
        
    }
   
}
