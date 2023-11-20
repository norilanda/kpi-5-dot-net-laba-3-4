using TheatreBoxOffice.Common.Enums;

namespace TheatreBoxOffice.Common.DTO.PerformanceTickets;

public record TicketsAggregatedDto
{
    public TicketStatus Status { get; init; }
    public decimal Price { get; init; }
    public int TicketsNumber { get; init; }
    public List<TicketInfo> Tickets { get; init; } = default!;
}

public record TicketInfo(long Id, int Seat);
