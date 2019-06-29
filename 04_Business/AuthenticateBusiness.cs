using DAL;
using DTO;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class AuthenticateBusiness
    {
        AuthenticationDB _context = new AuthenticationDB();
        public List<RoleDto> GetRolesDto()
        {
            List<RoleDto> Roles = (from b in _context.Roles.ToList()
                        select new RoleDto()
                        {
                            Id = b.Id,
                            Name = b.Name,
                            Enable = b.Enable
                        }).ToList();
            return Roles;
            
        }
    }
}
