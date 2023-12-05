using TheatreBoxOffice.DAL.Entities.Abstract;

namespace TheatreBoxOffice.DAL.Entities;

public class TicketPriceType : BaseEntity<long>
{
    public long PerformanceId { get; set; }
    public decimal Price { get; set; }
    public int SeatCategory { get; set; }

    public Performance Performance { get; set; } = null!;
    public ICollection<Seat> Seats { get; set; } = new List<Seat>();
    public ICollection<OrderTicket> OrderTickets { get; set; } = new List<OrderTicket>();
}
