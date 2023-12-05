using TheatreBoxOffice.DAL.Entities.Abstract;

namespace TheatreBoxOffice.DAL.Entities;

public class Seat : BaseEntity<long>
{
    public int SeatCategory { get; set; }
    public int Row { get; set; }
    public int Number { get; set; }

    public ICollection<TicketPriceType> TicketPriceTypes { get; set; } = new List<TicketPriceType>(); 
    public ICollection<OrderTicket> OrderTickets { get; set; } = new List<OrderTicket>();
}
