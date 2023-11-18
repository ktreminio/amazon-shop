using System.Runtime.Serialization;

namespace Ecommerce.Domain.Enums
{
    public enum ProductSatusEnum
    {
        [EnumMember(Value = "Producto Inactivo")]
        Inactivo,
        [EnumMember(Value = "Producto Activo")]
        Activo
    }
}
