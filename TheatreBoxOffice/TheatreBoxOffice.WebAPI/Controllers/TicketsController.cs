using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheatreBoxOffice.Common.DTO.Ticket;

namespace TheatreBoxOffice.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class TicketsController : ControllerBase
{
    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<TicketDto>> Get(long id)
    {
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "Manager")]
    public async Task<ActionResult<TicketDto>> Put(long id, [FromBody] TicketUpdateDto newTicket)
    {
        throw new NotImplementedException();
    }

    [HttpPost("{id}")]
    [Authorize(Roles = "Manager")]
    public async Task<ActionResult<TicketDto>> Post(long id, [FromBody] TicketCreateDto newTicket)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "Manager")]
    public async Task<ActionResult> Delete(long id)
    {
        throw new NotImplementedException();
    }
    
    [HttpPost("buy")]
    public async Task<ActionResult<UserTicketsDto>> Buy([FromBody] List<long> ids)
    {
        throw new NotImplementedException();
    }

    [HttpPost("reserve")]
    public async Task<ActionResult<UserTicketsDto>> Reserve([FromBody] List<long> ids)
    {
        throw new NotImplementedException();
    }
}
