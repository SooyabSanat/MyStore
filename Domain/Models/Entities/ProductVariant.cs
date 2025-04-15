using Domain.Models.Relations;

namespace Domain.Models.Entities
{
    public class ProductVariant: Base
    {
        public int ProductId { get; set; }
        public decimal Price { get; set; }  // قیمت برای این ترکیب ویژگی
        public int StockQuantity { get; set; }  // موجودی این واریانت

        public Product Product { get; set; }
        public ICollection<ProductVariantAttribute> VariantAttributes { get; set; } = new List<ProductVariantAttribute>();

    }
}