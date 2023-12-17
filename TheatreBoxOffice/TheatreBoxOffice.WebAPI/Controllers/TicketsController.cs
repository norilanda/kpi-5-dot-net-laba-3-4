using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheatreBoxOffice.BLL.Interfaces;
using TheatreBoxOffice.Common.DTO.Order;
using TheatreBoxOffice.Common.DTO.PerformanceTickets;

namespace TheatreBoxOffice.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class TicketsController : ControllerBase
{
    private readonly ITicketService _ticketService;

    public TicketsController(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    [HttpPut("{ticketTypeId}")]
    [Authorize(Roles = "Manager")]
    public async Task<ActionResult<TicketsAggregatedDto>> UpdateTicketTypeForPerformance(long ticketTypeId, PerformanceTicketsUpdateDto newTicketType)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{ticketTypeId}")]
    [Authorize(Roles = "Manager")]
    public async Task<ActionResult> DeleteTicketTypeForPerformance(long ticketTypeId)
    {
        throw new NotImplementedException();
    }

    [HttpPost("buy")]
    public async Task<ActionResult<OrderDto>> Buy([FromBody] List<OrderTicketDto> tickets)
    {
        var userId = GetCurrentUserId();
        if (userId == null)
            return Unauthorized();

        var entities = await _ticketService.BuyTicketsAsync(userId, tickets);
        return Ok(entities);
    }

    [HttpPost("reserve")]
    public async Task<ActionResult<OrderDto>> Reserve([FromBody] List<OrderTicketDto> tickets)
    {
        var userId = GetCurrentUserId();
        if (userId == null)
            return Unauthorized();

        var entities = await _ticketService.ReserveTicketsAsync(userId, tickets);
        return Ok(entities);
    }

    private string? GetCurrentUserId()
    {
        return User.FindFirst("id")?.Value;
    }
}
