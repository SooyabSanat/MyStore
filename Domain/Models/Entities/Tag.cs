using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class Tag : Base
    {
        [Display(Name = "نام تگ")]
        [Required(ErrorMessage = "نام تگ الزامی است.")]
        public string Name { get; set; }

        
    }
}
