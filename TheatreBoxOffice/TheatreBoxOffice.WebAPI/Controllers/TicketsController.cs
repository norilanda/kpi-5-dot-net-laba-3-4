using Microsoft.AspNetCore.Mvc;
using TheatreBoxOffice.Common.DTO.Ticket;

namespace TheatreBoxOffice.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketsController : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<ActionResult<TicketDto>> Get(long id)
    {
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<TicketDto>> Put(long id, [FromBody] TicketUpdateDto newTicket)
    {
        throw new NotImplementedException();
    }

    [HttpPost("{id}")]
    public async Task<ActionResult<TicketDto>> Post(long id, [FromBody] TicketCreateDto newTicket)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(long id)
    {
        throw new NotImplementedException();
    }
    
    [HttpPost("buy")]
    public async Task<ActionResult<UserTicketsDto>> Buy([FromBody] List<long> ids)
    {
        throw new NotImplementedException();
    }

    [HttpPost("book")]
    public async Task<ActionResult<UserTicketsDto>> Reserve([FromBody] List<long> ids)
    {
        throw new NotImplementedException();
    }
}
