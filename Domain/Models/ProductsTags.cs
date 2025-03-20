using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class ProductsTags
    {
        [Display(Name = "شناسه محصول")]
        [Required(ErrorMessage = "لطفا شناسه محصول را وارد کنید")]
        public int ProductId { get; set; }
        
        [Display(Name = "محصول")]
        public Product Product { get; set; }

        [Display(Name = "شناسه برچسب")]
        [Required(ErrorMessage = "لطفا شناسه برچسب را وارد کنید")]
        public int TagId { get; set; }
        
        [Display(Name = "برچسب")]
        public Tag Tag { get; set; }
    }
}
