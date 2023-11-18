using Ecommerce.Domain.Common;

namespace Ecommerce.Domain.Entities
{
    public class Image : BaseDomainModel
    {
        public string? Url { get; set; }
        public int ProductId { get; set; }
        public string PublicCode { get; set; }
    }
}
