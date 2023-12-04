using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheatreBoxOffice.Common.DTO.Order;
using TheatreBoxOffice.Common.DTO.PerformanceTickets;

namespace TheatreBoxOffice.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class TicketsController : ControllerBase
{
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
        throw new NotImplementedException();
    }

    [HttpPost("reserve")]
    public async Task<ActionResult<OrderDto>> Reserve([FromBody] List<OrderTicketDto> tickets)
    {
        throw new NotImplementedException();
    }
}
