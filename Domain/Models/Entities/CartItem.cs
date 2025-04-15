using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    [Display(Name = "آیتم سبد خرید")]
    public class CartItem : Base
    {
        [Required(ErrorMessage = "سبد خرید الزامی است")]
        [Display(Name = "سبد خرید")]
        public int CartId { get; set; }

        [Required(ErrorMessage = "محصول الزامی است")]
        [Display(Name = "محصول")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "تعداد الزامی است")]
        [Display(Name = "تعداد")]
        [Range(1, int.MaxValue, ErrorMessage = "تعداد باید بزرگتر از صفر باشد")]
        public int Quantity { get; set; }

        public virtual Cart Cart { get; set; }
        public virtual Product Product { get; set; }
    }
}
