namespace TheatreBoxOffice.Common.DTO.Order;

public record OrderTicketDto
{
    public long PerformanceTicketTypeId { get; set; }
    public int SeatNumber { get; set; }
}
