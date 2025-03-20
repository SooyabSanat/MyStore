using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
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

        [Display(Name = "وضعیت")]
        public bool IsActive { get; set; }

        [Display(Name = "دسته بندی")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
