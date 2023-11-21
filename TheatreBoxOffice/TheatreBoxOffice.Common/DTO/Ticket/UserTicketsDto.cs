using TheatreBoxOffice.Common.DTO.User;

namespace TheatreBoxOffice.Common.DTO.Ticket;

public record UserTicketsDto
{
    public List<UserTicketDto> Tickets { get; init; } = default!;
    public UserDto User { get; init; } = default!;
}

public record UserTicketDto : TicketDto
{
    public DateTime OrderDate { get; init; }
}
