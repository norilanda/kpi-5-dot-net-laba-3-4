using TheatreBoxOffice.DAL.Entities.Abstract;

namespace TheatreBoxOffice.DAL.Entities;

public class Seat : BaseEntity<long>
{
    public int SeatCategoryId { get; set; }
    public int Row { get; set; }
    public int Number { get; set; }

    public SeatCategory SeatCategory { get; set; } = default!;
    public ICollection<OrderTicket> OrderTickets { get; set; } = new List<OrderTicket>();
}
