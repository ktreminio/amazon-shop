using Ecommerce.Domain.Common;
using Ecommerce.Domain.Enums;

namespace Ecommerce.Domain.Entities
{
    public class Order : BaseDomainModel
    {
        public Order() { }

        public Order(
            string customerName,
            string customerEmail,
            OrderAddress orderAddress,
            decimal subtotal,
            decimal total,
            decimal tax,
            decimal priceShipping
        )
        {
            CustomerName = customerName;
            CustomerUserName = customerEmail;
            OrderAddress = orderAddress;
            Subtotal = subtotal;
            Total = total;
            Tax = tax;
            PriceShipping = priceShipping;
        }

        public string? CustomerName { get; set; }
        public string? CustomerUserName { get; set; }
        public OrderAddress? OrderAddress { get; set; }
        public IReadOnlyList<OrderItem>? OrderItems { get; set; }
        public decimal Subtotal { get; set; }
        public OrderStatusEnum Status { get; set; } = OrderStatusEnum.Pending;
        public decimal? Total { get; set; }
        public decimal? Tax { get; set;}
        public decimal? PriceShipping { get; set; }
        public string? PaymentIntentId { get; set; }
        public string? ClientSecret { get; set; }
        public string? StripeApiKey { get; set; }
    }
}
