using Domain.Models.Relations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class Product : Base
    {
        [Required(ErrorMessage = "نام محصول الزامی است")]
        [Display(Name = "نام محصول")]
        [MaxLength(100, ErrorMessage = "نام محصول نمی تواند بیشتر از 100 کاراکتر باشد")]
        public string Name { get; set; }


        [Display(Name = "توضیحات")]
        public string Description { get; set; }


        [Required(ErrorMessage = "قیمت محصول الزامی است")]
        [Display(Name = "قیمت")]
        [Range(0, double.MaxValue, ErrorMessage = "قیمت باید بزرگتر از صفر باشد")]
        public decimal Price { get; set; }


        [Display(Name = "تصویر محصول")]
        public string ImageUrl { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }


        [Display(Name = "موجودی")]
        [Range(0, int.MaxValue, ErrorMessage = "موجودی باید بزرگتر از صفر باشد")]
        public int Stock { get; set; }

        [Required]
        [Display(Name = "دسته بندی")]
        public int CategoryId { get; set; }
        
        [Display(Name = "دسته بندی")]
        public virtual Category Category { get; set; }


        [Display(Name = "تگ ها")]
        public virtual ICollection<ProductsTags> ProductsTags { get; set; } = new  List<ProductsTags>();
        

        [Display(Name = "ویژگی های تاثیر گذار بر قیمت")]
        public ICollection<ProductVariant> Variants { get; set; } = new List<ProductVariant>();


        [Display(Name = "ویژگی ها")]
        public ICollection<ProductAttribute> Attributes { get; set; } = new List<ProductAttribute>();

    }
}
