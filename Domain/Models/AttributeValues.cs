using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class AttributeValues : Base
    {
        [Required]
        public int AttributeId { get; set; }

        [Required]
        [Display(Name = "مقدار")]
        public string Value { get; set; }

        public Domain.Models.Attribute Attribute { get; set; }
    }
}
