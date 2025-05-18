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
        [Display(Name = "محصول")]
        public int ProductId { get; set; }
        
        [Display(Name = "محصول")]
        public Product Product { get; set; }

        [Required]
        [Display(Name = "ویژگی")]
        public int AttributeId { get; set; }

        [Display(Name = "ویژگی")]
        public Entities.Attribute Attribute { get; set; }

        [Required]
        [Display(Name = "مقدار")]
        public int AttributeValueId { get; set; }
        
        [Display(Name = "مقدار")]
        public AttributeValue AttributeValue { get; set; }


        [Display(Name = "جایگاه نمایش ")]
        public int? DisplayOrder { get; set; } = int.MaxValue;
    }
}
