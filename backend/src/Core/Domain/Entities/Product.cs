using Ecommerce.Domain.Common;
using Ecommerce.Domain.Enums;

namespace Ecommerce.Domain.Entities
{
    public class Product : BaseDomainModel
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public int Rating { get; set; }
        public int EmployeeId { get; set; }
        public int Stock {  get; set; }
        public ProductSatusEnum Status { get; set; } = ProductSatusEnum.Activo;
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }
        public virtual ICollection<Image>? Images { get; set; }
    }
}
