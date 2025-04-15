using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Entities;

namespace Domain.Models.Relations
{
    public class ProductAttribute : Base
    {
        [Required]
        public int ProductId { get; set; }
        
        [Required]
        public int AttributeValueId { get; set; }

        [ForeignKey("ProductId")]
        [Display(Name = "محصول")]
        public Product Product { get; set; }

        [Display(Name = "ویژگی")]
        public AttributeValue AttributeValue { get; set; }
    }
}
