using TheatreBoxOffice.BLL.Interfaces;
using TheatreBoxOffice.Common.DTO.Order;
using TheatreBoxOffice.Common.DTO.PerformanceTickets;

namespace TheatreBoxOffice.BLL.Services;

public class TicketService : ITicketService
{
    public Task<TicketsAggregatedDto> AddTicketTypeAsync(PerformanceTicketsCreateDto newTicketType)
    {
        throw new NotImplementedException();
    }

    public Task<OrderDto> BuyTicketsAsync(List<OrderTicketDto> tickets)
    {
        throw new NotImplementedException();
    }

    public Task DeleteTicketTypeAsync(long ticketTypeId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TicketsAggregatedDto>> GetTicketsInfoForPerformanceAsync(long performanceId)
    {
        throw new NotImplementedException();
    }

    public Task<OrderDto> ReserveTicketsAsync(List<OrderTicketDto> tickets)
    {
        throw new NotImplementedException();
    }

    public Task<TicketsAggregatedDto> UpdateTicketTypeAsync(PerformanceTicketsUpdateDto newTicketType)
    {
        throw new NotImplementedException();
    }
}
