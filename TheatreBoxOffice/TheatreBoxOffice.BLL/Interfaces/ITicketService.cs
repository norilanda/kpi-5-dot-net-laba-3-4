using TheatreBoxOffice.Common.DTO.Order;
using TheatreBoxOffice.Common.DTO.PerformanceTickets;

namespace TheatreBoxOffice.BLL.Interfaces;

public interface ITicketService
{
    public Task<IEnumerable<TicketsAggregatedDto>> GetTicketsInfoForPerformanceAsync(long performanceId);
    public Task<TicketsAggregatedDto> AddTicketTypeAsync(long performanceId, PerformanceTicketsCreateDto newTicketType);
    public Task<OrderDto> BuyTicketsAsync(string userId, List<OrderTicketDto> tickets);
    public Task<OrderDto> ReserveTicketsAsync(string userId, List<OrderTicketDto> tickets);
}
