using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Lesson
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string ImageUrl { set; get; }
        public string VideoUrl { set; get; }
        public bool isVip { set; get; }
        [ForeignKey("Course")]
        public int CourseId { set; get; }
        public virtual Course Course { set; get; }
    }
}
