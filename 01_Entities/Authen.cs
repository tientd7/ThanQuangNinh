using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class User : IdentityUser
    {
        public User()
        {
        }
        public string Address { get; set; }
        public string Sex { get; set; }
        public bool IsVip { set; get; }
        public bool Enable { set; get; }
    }
    public class Role : IdentityRole
    {
        public Role() : base()
        {
            Enable = true;
        }
        public Role(string roleName) : base(roleName)
        {
            Enable = true;
        }

        public bool Enable { set; get; }
    }

    
}
