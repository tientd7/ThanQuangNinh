using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoleDto
    {
       
        public string Id { set; get; }
        public string Name { set; get; }
        public bool Enable { set; get; }
    }
    public class RoleEnum
    {
        public const string Admin = "Administrator";
        public const string Manager = "Manager";
        public const string Owner = "Owner";
        public const string Editor = "Editor";
    }
}
