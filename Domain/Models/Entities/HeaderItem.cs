using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class HeaderItem : Base
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public int? ParentId { get; set; } 
        public HeaderItem Parent { get; set; }
        public ICollection<HeaderItem> Children { get; set; } = new List<HeaderItem>();

    }
}
