using Ardalis.Specification;
using TheatreBoxOffice.DAL.Entities;

namespace TheatreBoxOffice.BLL.Specifications.PerformanceSpecs;

public class SeatSpec : Specification<Seat>
{
    public SeatSpec(int seatNumber, long ticketPriceType)
    {
        Query.Where(s => s.Number == seatNumber && s.SeatCategory.TicketPriceTypes.Any(t => t.Id == ticketPriceType))
            .Include(s => s.OrderTickets)
            ;

    }
}
