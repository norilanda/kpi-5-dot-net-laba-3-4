using TheatreBoxOffice.DAL.Entities.Abstract;

namespace TheatreBoxOffice.DAL.Entities;

public class TicketPriceType : BaseEntity<long>
{
    public long PerformanceId { get; set; }
    public decimal Price { get; set; }
    public int SeatCategoryId { get; set; }

    public SeatCategory SeatCategory { get; set; } = default!;
    public Performance Performance { get; set; } = null!;
    public ICollection<OrderTicket> OrderTickets { get; set; } = new List<OrderTicket>();
}
