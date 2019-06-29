using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoleDto
    {
        public static string Admin = "Administrator";
        public static string Manager = "Manager";
        public static string Owner = "Owner";
        public static string Editor = "Editor";
        public string Id { set; get; }
        public string Name { set; get; }
        public bool Enable { set; get; }
    }
}
