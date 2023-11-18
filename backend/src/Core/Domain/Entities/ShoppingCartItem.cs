using Ecommerce.Domain.Common;

namespace Ecommerce.Domain.Entities
{
    public class ShoppingCartItem : BaseDomainModel
    {
        public string? Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string? Image { get; set; }
        public string? Category { get; set; }
        public Guid? ShoppingCartMasterId { get; set; }
        public int ShoppingCartId { get; set; }
        public int ProductId { get; set; }
        public int Stock { get; set; }
    }
}
