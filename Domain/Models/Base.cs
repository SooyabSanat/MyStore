using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Base
    {
        [Key]
        [Display(Name = "شناسه")]
        public int Id { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime? UpdatedAt { get; set; }

        [Display(Name = "حذف شده")]
        public bool IsDeleted { get; set; } = false;
    }
}
