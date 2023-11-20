using TheatreBoxOffice.Common.Enums;

namespace TheatreBoxOffice.Common.DTO.Ticket;

public class TicketUpdateDto
{
    public long Id { get; set; }
    public int Seat { get; set; }
    public decimal Price { get; set; }
    public TicketStatus Status { get; set; }
    public long PerformanceId { get; set; }
}
