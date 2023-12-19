using TheatreBoxOffice.Common.Enums;

namespace TheatreBoxOffice.Common.DTO.PerformanceTickets;

public class TicketsAggregatedDto
{
    public TicketType TicketType { get; set; } = default!;
    public List<TicketInfo> Tickets { get; set; } = default!;
}

public record TicketType(long TicketTypeId, decimal Price);

public class TicketInfo
{
    public int SeatRow { get; set; }
    public int SeatNumber { get; set; }
    public long TicketTypeId { get; set; }
    public TicketStatus Status { get; set; }
}

