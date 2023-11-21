using TheatreBoxOffice.Common.Enums;

namespace TheatreBoxOffice.Common.DTO.PerformanceTickets;

public record TicketsAggregatedCreateDto
{
    public List<int> Seats { get; init; } = default!;
    public decimal Price { get; init; }
    public TicketStatus Status { get; init; }
}
