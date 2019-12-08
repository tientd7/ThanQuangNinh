using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TopicDTO
    {
        public Paging Pager { set; get; }
        public IEnumerable<TopicComponents> Components { set; get; }
    }
    public class TopicComponents
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }
        public bool IsEnable { set; get; }
    }
}
