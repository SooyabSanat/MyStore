using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    [Display(Name = "سفارش")]
    public class Order : Base
    {
        [Required(ErrorMessage = "کاربر الزامی است")]
        [Display(Name = "کاربر")]
        public int UserId { get; set; }
       

        [Required(ErrorMessage = "وضعیت سفارش الزامی است")]
        [Display(Name = "وضعیت سفارش")]
        public string Status { get; set; }

        [Required(ErrorMessage = "مبلغ کل الزامی است")]
        [Display(Name = "مبلغ کل")]
        public decimal TotalAmount { get; set; }

        [Display(Name = "کاربر")]
        public virtual User User { get; set; }

        [Display(Name = "آیتم های سفارش")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        [Display(Name = "پرداخت ها")]
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
