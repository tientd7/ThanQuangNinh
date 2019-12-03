using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IEntity
    {
        [Key]
        int Id { set; get; }
        string Name { set; get; }
    }
}
