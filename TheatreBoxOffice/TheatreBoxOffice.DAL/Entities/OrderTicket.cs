namespace TheatreBoxOffice.DAL.Entities;

public class OrderTicket
{
    public long OrderId { get; set; }
    public long SeatId { get; set; }
    public long TicketPriceTypeId { get; set; }

    public Order Order { get; set; } = null!;
    public Seat Seat { get; set; } = null!;
    public TicketPriceType TicketPriceType { get; set; } = null!;
}
