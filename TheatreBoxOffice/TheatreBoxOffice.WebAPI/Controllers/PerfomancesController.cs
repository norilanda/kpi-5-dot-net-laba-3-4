using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheatreBoxOffice.Common.DTO.Performance;
using TheatreBoxOffice.Common.DTO.PerformanceTickets;

namespace TheatreBoxOffice.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "Manager")]
public class PerfomancesController : ControllerBase
{
    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<PerformanceDto>> Get(long id)
    {
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<PerformanceDto>> Put(long id, [FromBody] PerformanceUpdateDto newPerformance)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<ActionResult<PerformanceDto>> Create([FromBody] PerformanceCreateDto newPerformance)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(long id)
    {
        throw new NotImplementedException();
    }

    [HttpGet("search")]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<PerformanceDto>>> GetFilteredPerformances([FromQuery] PerformanceFilterDto filter)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}/tickets-info")]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<TicketsAggregatedDto>>> GetPerformanceTicketsInfo(long id)
    {
        throw new NotImplementedException();
    }

    [HttpPost("{id}/tickets")]
    public async Task<ActionResult<TicketsCreationResult>> AddTicketsToPerformance(long id, [FromBody] List<TicketsAggregatedCreateDto> tickets)
    {
        throw new NotImplementedException();
    }
}
