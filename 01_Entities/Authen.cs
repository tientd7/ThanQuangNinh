using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class User : IdentityUser
    {
        public User()
        {
        }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        public DateTime? VipExp { set; get; }
        public bool IsVip { set; get; }
        public bool IsEnable { set; get; }
    }
    //public class Role : IdentityRole
    //{
    //    public Role() : base()
    //    {
    //        Enable = true;
    //    }
    //    public Role(string roleName) : base(roleName)
    //    {
    //        Enable = true;
    //    }

    //    public bool Enable { set; get; }
    //}

    
}
