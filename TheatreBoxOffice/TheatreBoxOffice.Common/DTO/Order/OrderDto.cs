using TheatreBoxOffice.Common.DTO.Ticket;
using TheatreBoxOffice.Common.DTO.User;
using TheatreBoxOffice.Common.Enums;

namespace TheatreBoxOffice.Common.DTO.Order;

public record OrderDto
{
    public long OrderId { get; init; }
    public DateTime OrderDate { get; init; }
    public OrderStatus Status { get; init; }
    public decimal Price { get; init; }
    public List<TicketDto> Tickets { get; init; } = default!;
    public UserDto User { get; init; } = default!;
}
