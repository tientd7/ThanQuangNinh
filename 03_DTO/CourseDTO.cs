using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CourseDTO
    {
        public CourseDTO()
        {
            Pager = new Paging();
            Components = new List<CourseComponent>();
        }
        public Paging Pager { set; get; }
        public ICollection<CourseComponent> Components { set; get; }

    }
    public class CourseComponent
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string ImageUrl { set; get; }
        public bool IsEnable { set; get; }
    }

}
