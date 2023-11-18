using System.Runtime.Serialization;

namespace Ecommerce.Domain.Enums
{
    public enum OrderStatusEnum
    {
        [EnumMember(Value = "Pendiente")]
        Pending,
        [EnumMember(Value = "Completado")]
        Completed,
        [EnumMember(Value = "Enviado")]
        Shipped,
        [EnumMember(Value = "Cancelado")]
        Canceled,
        [EnumMember(Value = "Error")]
        Error
    }
}
