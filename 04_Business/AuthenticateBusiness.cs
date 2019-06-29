using Business.Interface;
using Entities;
using DAL;
using System.Linq;
using System.Data.Entity;
using DAL.Interface;

namespace Business
{
    public class AuthenticateBusiness: IAuthenBusiness
    {
        IDbContext _context;
        public AuthenticateBusiness(IDbContext context)
        {
            _context = context;
        }
        public string[] GetRolesDto()
        {
            var roles = (from b in _context.Set<Role>().ToList()
                        select b.Name).ToArray();
            return roles;
            
        }
    }
}
