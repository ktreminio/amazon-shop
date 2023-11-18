using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Domain.Entities
{
    public class User : IdentityUser
    {
        public string? FirtsName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Avatar { get; set; }
        public bool IsActive { get; set; }
    }
}
