using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    [Display(Name = "سبد خرید")]
    public class Cart : Base
    {
        [Required(ErrorMessage = "کاربر الزامی است")]
        [Display(Name = "کاربر")]
        public int UserId { get; set; }

        [Display(Name = "کاربر")]
        public virtual User User { get; set; }

        [Display(Name = "آیتم های سبد خرید")]
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
