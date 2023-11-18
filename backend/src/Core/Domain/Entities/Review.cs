using Ecommerce.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Entities
{
    public class Review : BaseDomainModel
    {
        [Column(TypeName = "NVARCHAR(100)")]
        public string? Name { get; set; }
        public int Rating { get; set; }
        [Column(TypeName = "NVARCHAR(3000)")]
        public string? Comment { get; set; }
        public int ProductId { get; set; }
    }
}
