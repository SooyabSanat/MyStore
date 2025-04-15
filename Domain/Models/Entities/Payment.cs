using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    [Display(Name = "پرداخت")]
    public class Payment : Base
    {
        [Required(ErrorMessage = "سفارش الزامی است")]
        [Display(Name = "سفارش")]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "مبلغ الزامی است")]
        [Display(Name = "مبلغ")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "روش پرداخت الزامی است")]
        [Display(Name = "روش پرداخت")]
        public string PaymentMethod { get; set; }

        [Display(Name = "شماره تراکنش")]
        public string TransactionId { get; set; }

        [Required(ErrorMessage = "تاریخ پرداخت الزامی است")]
        [Display(Name = "تاریخ پرداخت")]
        public DateTime PaymentDate { get; set; }

        [Required(ErrorMessage = "وضعیت پرداخت الزامی است")]
        [Display(Name = "وضعیت پرداخت")]
        public string Status { get; set; }

        public virtual Order Order { get; set; }
    }
}
