using Ardalis.Specification;
using TheatreBoxOffice.Common.DTO.PerformanceTickets;
using TheatreBoxOffice.Common.Enums;
using TheatreBoxOffice.DAL.Entities;

namespace TheatreBoxOffice.BLL.Specifications.PerformanceSpecs;

public class PerformanceTicketSpec : Specification<TicketPriceType, TicketsAggregatedDto>
{
    public PerformanceTicketSpec(long id, bool isPerformanceId = true)
    {
        if (isPerformanceId)
            Query.Where(t => t.PerformanceId == id);
        else 
            Query.Where(t => t.Id == id);


        Query
            .Include(t => t.SeatCategory)
                .ThenInclude(t => t.Seats)
            .Include(t => t.OrderTickets)
            ;

        Query.Select(t => new TicketsAggregatedDto()
        {
            TicketType = new (t.Id, t.Price),
            Tickets = t.SeatCategory.Seats.Select(s => new TicketInfo()
            {
                SeatRow = s.Row,
                SeatNumber = s.Number,
                TicketTypeId = t.Id,
                Status = t.OrderTickets.Any(o => o.SeatId == s.Id) ? TicketStatus.NotAvailable : TicketStatus.Available,
            })
            .ToList()
        });
    }
}
