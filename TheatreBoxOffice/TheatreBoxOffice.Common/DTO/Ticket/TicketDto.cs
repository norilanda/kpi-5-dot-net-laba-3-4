using TheatreBoxOffice.Common.DTO.Performance;

namespace TheatreBoxOffice.Common.DTO.Ticket;

public record TicketDto
{
    public int SeatRow { get; init; }
    public int SeatNumber { get; init; }
    public decimal Price { get; init; }
    public PerformanceDto Performance { get; init; } = default!;
}
