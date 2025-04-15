using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Domain.Models.Enums;

namespace Domain.Models.Entities
{
    public class User : Base
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "ایمیل الزامی است")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "رمز عبور الزامی است")]
        [MinLength(6,ErrorMessage = "حداقل 6 کارکتر")]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage = "حداکثر 50 کارکتر")]
        [Display(Name = "نام")]
        public string FirstName { get; set; }

        [MaxLength(50,ErrorMessage = "حداکثر 50 کارکتر")]
        [Display(Name = "نام خانوادگی")]
        public string? LastName { get; set; }

        [Phone]
        [Required(ErrorMessage = "شماره تلفن الزامی است")]
        [Display(Name = "شماره تلفن")]
        public string PhoneNumber { get; set; }

        [MaxLength(500)]
        [Required(ErrorMessage = "آدرس الزامی است")]
        [Display(Name = "آدرس")]
        public string Address { get; set; }

        [Required(ErrorMessage = "نقش الزامی است")]
        [Display(Name = "نقش")]
        public Roles Role { get; set; } = Roles.user;

        // Navigation properties
        public virtual Cart Cart { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
