using Business.Interface;
using Entities;
using DAL;
using System.Linq;
using System.Data.Entity;

namespace Business
{
    public class AuthenticateBusiness: IAuthenBusiness
    {
        AuthenticationDB _context;
        public AuthenticateBusiness()
        {
            _context = new AuthenticationDB();
        }
        public string[] GetRolesDto()
        {
            var roles = (from b in _context.Roles.ToList()
                        select b.Name).ToArray();
            return roles;
            
        }
    }
}
