using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    [Display(Name = "آیتم سفارش")]
    public class OrderItem : Base
    {
        [Required(ErrorMessage = "سفارش الزامی است")]
        [Display(Name = "سفارش")]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "محصول الزامی است")]
        [Display(Name = "محصول")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "تعداد الزامی است")]
        [Display(Name = "تعداد")]
        [Range(1, int.MaxValue, ErrorMessage = "تعداد باید بزرگتر از صفر باشد")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "قیمت واحد الزامی است")]
        [Display(Name = "قیمت واحد")]
        public decimal UnitPrice { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
