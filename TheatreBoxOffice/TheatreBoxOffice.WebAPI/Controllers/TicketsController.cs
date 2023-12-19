using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheatreBoxOffice.BLL.Interfaces;
using TheatreBoxOffice.Common.DTO.Order;

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
