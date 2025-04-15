using Domain.Models.Entities;

namespace Domain.Models.Relations
{
    public class ProductVariantAttribute : Base
    {
        public int ProductVariantId { get; set; }
        public int AttributeValueId { get; set; }

        public ProductVariant ProductVariant { get; set; }
        public AttributeValue AttributeValue { get; set; }
    }
}