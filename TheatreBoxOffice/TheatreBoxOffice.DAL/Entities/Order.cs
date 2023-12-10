using Microsoft.AspNetCore.Identity;
using TheatreBoxOffice.Common.Enums;
using TheatreBoxOffice.DAL.Entities.Abstract;

namespace TheatreBoxOffice.DAL.Entities;

public class Order : BaseEntity<long>
{
    public string UserId { get; set; } = string.Empty;
    public OrderStatus Status { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Price { get; set; }

    public IdentityUser User { get; set; } = null!;
    public ICollection<OrderTicket> OrderTickets { get; set; } = new List<OrderTicket>();
}
