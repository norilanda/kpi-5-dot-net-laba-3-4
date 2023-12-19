using TheatreBoxOffice.Common.DTO.Ticket;
using TheatreBoxOffice.Common.DTO.User;
using TheatreBoxOffice.Common.Enums;

namespace TheatreBoxOffice.Common.DTO.Order;

public class OrderDto
{
    public long OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public OrderStatus Status { get; set; }
    public List<TicketDto> Tickets { get; set; } = default!;
    public UserDto User { get; set; } = default!;
}
