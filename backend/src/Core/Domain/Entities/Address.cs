using Ecommerce.Domain.Common;

namespace Ecommerce.Domain.Entities
{
    public class Address : BaseDomainModel
    {
        public string? Description { get; set; }
        public string? City { get; set; }
        public string? Departament { get; set; }
        public string? PostalCode { get; set; }
        public int UserId { get; set; }
        public int CountryId { get; set; }
    }
}
