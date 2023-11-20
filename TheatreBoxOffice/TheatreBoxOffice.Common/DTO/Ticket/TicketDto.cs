using TheatreBoxOffice.Common.DTO.Performance;
using TheatreBoxOffice.Common.Enums;

namespace TheatreBoxOffice.Common.DTO.Ticket;

public record TicketDto
{
    public long Id { get; init; }
    public int Seat { get; init; }
    public decimal Price { get; init; }
    public TicketStatus Status { get; init; }
    public PerformanceDto Performance { get; init; } = default!;
}
