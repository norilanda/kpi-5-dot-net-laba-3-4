using TheatreBoxOffice.DAL.Entities.Abstract;

namespace TheatreBoxOffice.DAL.Entities;

public class SeatCategory : BaseEntity<int>
{
    public ICollection<TicketPriceType> TicketPriceTypes { get; set; } = new List<TicketPriceType>();
    public ICollection<Seat> Seats { get; set; } = new List<Seat>();
}
