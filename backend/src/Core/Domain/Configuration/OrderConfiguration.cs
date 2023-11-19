using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Domain.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.OwnsOne(o => o.OrderAddress, a =>
            {
                a.WithOwner();
            });

            builder.HasMany(o => o.OrderItems)
            .WithOne(oi => oi.Order)
            .HasForeignKey(oi => oi.OrderId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

            builder.Property(o => o.Status)
            .HasConversion(
                o => o.ToString(),
                o => (OrderStatusEnum)Enum.Parse(typeof(OrderStatusEnum), o)
            );

            builder.Property(o => o.Subtotal)
                .HasColumnType("decimal(10,2)");

            builder.Property(o => o.Total)
                .HasColumnType("decimal(10,2)");

            builder.Property(o => o.Tax)
                .HasColumnType("decimal(10,2)");

            builder.Property(o => o.PriceShipping)
                .HasColumnType("decimal(10,2)");
        }
    }
}
