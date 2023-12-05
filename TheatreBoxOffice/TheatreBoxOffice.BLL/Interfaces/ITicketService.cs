using TheatreBoxOffice.Common.DTO.Order;
using TheatreBoxOffice.Common.DTO.PerformanceTickets;

namespace TheatreBoxOffice.BLL.Interfaces;

public interface ITicketService
{
    public Task<IEnumerable<TicketsAggregatedDto>> GetTicketsInfoForPerformanceAsync(long performanceId);
    public Task<TicketsAggregatedDto> AddTicketTypeAsync(PerformanceTicketsCreateDto newTicketType);

    public Task<TicketsAggregatedDto> UpdateTicketTypeAsync(PerformanceTicketsUpdateDto newTicketType);
    public Task DeleteTicketTypeAsync(long ticketTypeId);
    public Task<OrderDto> BuyTicketsAsync(List<OrderTicketDto> tickets);
    public Task<OrderDto> ReserveTicketsAsync(List<OrderTicketDto> tickets);
}
