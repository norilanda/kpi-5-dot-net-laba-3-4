using Ardalis.Specification;
using TheatreBoxOffice.Common.DTO.Order;
using TheatreBoxOffice.Common.DTO.Performance;
using TheatreBoxOffice.Common.DTO.Ticket;
using TheatreBoxOffice.Common.DTO.User;
using TheatreBoxOffice.DAL.Entities;

namespace TheatreBoxOffice.BLL.Specifications.PerformanceSpecs;

public class OrderSpec : Specification<Order, OrderDto>
{
    public OrderSpec(long orderId)
    {
        Query.Where(o => o.Id == orderId)
            .Include(o => o.User)
            .Include(o => o.OrderTickets)
                .ThenInclude(o => o.Seat)
            .Include(o => o.OrderTickets)
                .ThenInclude(o => o.TicketPriceType)
            ;

        Query.Select(o => new OrderDto()
        {
            OrderId = o.Id,
            OrderDate = o.OrderDate,
            Status = o.Status,
            User = new UserDto()
            {
                Id = o.User.Id,
                Email = o.User.Email,
            },
            Tickets = o.OrderTickets.Select(t => new TicketDto()
            {
                SeatRow = t.Seat.Row,
                SeatNumber = t.Seat.Number,
                Price = t.TicketPriceType.Price,
                PerformanceId = t.TicketPriceType.PerformanceId

            }).ToList()
        });
    }
}
