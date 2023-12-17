using Ardalis.Specification;
using AutoMapper;
using TheatreBoxOffice.BLL.Exceptions;
using TheatreBoxOffice.BLL.Interfaces;
using TheatreBoxOffice.BLL.Specifications.PerformanceSpecs;
using TheatreBoxOffice.Common.DTO.Order;
using TheatreBoxOffice.Common.DTO.PerformanceTickets;
using TheatreBoxOffice.Common.Enums;
using TheatreBoxOffice.DAL.Entities;
using TheatreBoxOffice.DAL.Interfaces;

namespace TheatreBoxOffice.BLL.Services;

public class TicketService : ITicketService
{
    private readonly IMapper _mapper;
    private readonly IGenericRepository<TicketPriceType> _ticketPriceTypeRepository;
    private readonly IGenericRepository<SeatCategory> _seatCategoryRepository;
    private readonly IGenericRepository<Seat> _seatRepository;
    private readonly IGenericRepository<OrderTicket> _orderTicketRepository;
    private readonly IGenericRepository<Order> _orderRepository;

    public TicketService(IMapper mapper,
        IGenericRepository<TicketPriceType> ticketPriceTypeRepository,
        IGenericRepository<Seat> seatRepository,
        IGenericRepository<SeatCategory> seatCategoryRepository,
        IGenericRepository<OrderTicket> orderTicketRepository,
        IGenericRepository<Order> orderRepository
        )
    {
        _mapper = mapper;
        _ticketPriceTypeRepository = ticketPriceTypeRepository;
        _seatRepository = seatRepository;
        _seatCategoryRepository = seatCategoryRepository;
        _orderTicketRepository = orderTicketRepository;
        _orderRepository = orderRepository;
    }

    public async Task<IEnumerable<TicketsAggregatedDto>> GetTicketsInfoForPerformanceAsync(long performanceId)
    {
        var spec = new PerformanceTicketSpec(performanceId);

        var ticketsAggregated = await _ticketPriceTypeRepository.ListAsync(spec);

        return ticketsAggregated;
    }

    public async Task<TicketsAggregatedDto> AddTicketTypeAsync(long performanceId, PerformanceTicketsCreateDto newTicketType)
    {
        if (await _seatCategoryRepository.GetByIdAsync(newTicketType.SeatCategoryId) == null)
            throw ResponseException.BadRequest("Specified seat category does not exists.");

        var entity = _mapper.Map<TicketPriceType>(newTicketType);
        entity.PerformanceId = performanceId;

        await _ticketPriceTypeRepository.AddAsync(entity);
        await _ticketPriceTypeRepository.SaveChangesAsync();

        var spec = new PerformanceTicketSpec(entity.Id, false);
        var ticketsAggregated = await _ticketPriceTypeRepository.FirstOrDefaultAsync(spec);

        return ticketsAggregated!;
    }

    public async Task<OrderDto> BuyTicketsAsync(string userId, List<OrderTicketDto> tickets)
    {
        var orderTickets = await CreateOrderTicketsAsync(tickets);

        var order = new Order()
        {
            UserId = userId,
            Status = OrderStatus.Sold,
            OrderDate = DateTime.Now,
            OrderTickets = orderTickets
        };

        await _orderRepository.AddAsync(order);
        await _orderRepository.SaveChangesAsync();

        var orderSpec = new OrderSpec(order.Id);
        var orderDto = await _orderRepository.FirstOrDefaultAsync(orderSpec);

        return orderDto!;
    }

    public async Task<OrderDto> ReserveTicketsAsync(string userId, List<OrderTicketDto> tickets)
    {
        var orderTickets = await CreateOrderTicketsAsync(tickets);

        var order = new Order()
        {
            UserId = userId,
            Status = OrderStatus.Reserved,
            OrderDate = DateTime.Now,
            OrderTickets = orderTickets
        };

        await _orderRepository.AddAsync(order);
        await _orderRepository.SaveChangesAsync();

        var orderSpec = new OrderSpec(order.Id);
        var orderDto = await _orderRepository.FirstOrDefaultAsync(orderSpec);

        return orderDto!;
    }

    public Task<TicketsAggregatedDto> UpdateTicketTypeAsync(long performanceId, PerformanceTicketsUpdateDto newTicketType)
    {
        throw new NotImplementedException();
    }

    public Task DeleteTicketTypeAsync(long ticketTypeId)
    {
        throw new NotImplementedException();
    }

    private async Task<List<OrderTicket>> CreateOrderTicketsAsync(List<OrderTicketDto> tickets)
    {
        List<OrderTicket> orderTickets = new();

        foreach (var ticket in tickets)
        {
            var seatSpec = new SeatSpec(ticket.SeatNumber, ticket.PerformanceTicketTypeId);
            var seat = await _seatRepository.FirstOrDefaultAsync(seatSpec);
            if (seat == null)
                throw ResponseException.BadRequest();

            if (seat.OrderTickets.Any(o => o.TicketPriceTypeId == ticket.PerformanceTicketTypeId))
                throw ResponseException.BadRequest();

            var orderTicket = new OrderTicket()
            {
                SeatId = seat.Id,
                TicketPriceTypeId = ticket.PerformanceTicketTypeId,
            };
            orderTickets.Add(orderTicket);
        }

        return orderTickets;
    }
}
