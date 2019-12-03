using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Topic
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }
        public bool IsEnable { set; get; }
    }
}
