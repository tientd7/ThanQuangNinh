using Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AuthenticationDB: IdentityDbContext<User,Role,string,IdentityUserLogin,IdentityUserRole,IdentityUserClaim>
    {
        public AuthenticationDB() : base("BasicConnect")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        //public DbSet<User> Users { set; get; }
        //public DbSet<Role> Roles { set; get; }
    }
   
}
