using TheatreBoxOffice.Common.Enums;

namespace TheatreBoxOffice.Common.DTO.PerformanceTickets;

public record TicketsAggregatedDto
{
    public TicketType TicketType { get; init; } = default!;
    public List<TicketInfo> Tickets { get; init; } = default!;
}

public record TicketType(long TicketTypeId, decimal Price);

public record TicketInfo(
    int SeatRow, 
    int SeatNumber,
    long TicketTypeId, 
    TicketStatus Status);
