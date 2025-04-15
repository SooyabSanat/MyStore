using Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Domain.Models.ViewModels
{
    public class HeaderItemsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public int? ParentId { get; set; }
        public HeaderItem Parent { get; set; }
        public ICollection<HeaderItem> Children { get; set; } = new List<HeaderItem>();
    }
    
    
}
