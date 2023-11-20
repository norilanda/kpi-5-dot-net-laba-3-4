using TheatreBoxOffice.Common.Enums;

namespace TheatreBoxOffice.Common.DTO.Ticket;

public record TicketCreateDto
{
    public int Seat { get; init; }
    public decimal Price { get; init; }
    public TicketStatus Status { get; init; }
    public long PerformanceId { get; init; }
}
