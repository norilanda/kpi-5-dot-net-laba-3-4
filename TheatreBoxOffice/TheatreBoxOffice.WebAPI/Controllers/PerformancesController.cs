using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheatreBoxOffice.BLL.Interfaces;
using TheatreBoxOffice.BLL.Specifications.PerformanceSpecs;
using TheatreBoxOffice.Common.DTO.Performance;
using TheatreBoxOffice.Common.DTO.PerformanceTickets;

namespace TheatreBoxOffice.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
//[Authorize(Roles = "Manager")]
public class PerformancesController : ControllerBase
{
    private readonly IPerformanceService _performanceService;
    private readonly ITicketService _ticketService;

    public PerformancesController(IPerformanceService performanceService, ITicketService ticketService)
    {
        _performanceService = performanceService;
        _ticketService = ticketService;
    }

    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<PerformanceDto>> GetById(long id)
    {
        var entity = await _performanceService.GetByIdAsync(id);
        return Ok(entity);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<PerformanceDto>> Put(long id, [FromBody] PerformanceUpdateDto newPerformance)
    {
        newPerformance.Id = id;
        var entity = await _performanceService.UpdateAsync(newPerformance);
        return Ok(entity);
    }

    [HttpPost]
    public async Task<ActionResult<PerformanceDto>> Create([FromBody] PerformanceCreateDto newPerformance)
    {
        var entity = await _performanceService.CreateAsync(newPerformance);

        return CreatedAtAction(nameof(GetById), new { id = entity.Id }, entity);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(long id)
    {
        await _performanceService.DeleteAsync(id);
        return Ok();
    }

    [HttpGet("search")]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<PerformanceDto>>> GetFilteredPerformances([FromQuery] PerformanceFilterDto filter)
    {
        var entities = await _performanceService.GetFilteredPerformancesAsync(filter);
        return Ok(entities);
    }

    [HttpGet("{id}/tickets")]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<TicketsAggregatedDto>>> GetPerformanceTicketsInfo(long id)
    {
        var entities = await _ticketService.GetTicketsInfoForPerformanceAsync(id);
        return Ok(entities);
    }

    [HttpPost("{id}/tickets")]
    //[Authorize(Roles = "Manager")]
    public async Task<ActionResult<TicketsAggregatedDto>> CreateTicketTypeForPerformance(long id, [FromBody]PerformanceTicketsCreateDto newTicketType)
    {
        var entity = await _ticketService.AddTicketTypeAsync(id, newTicketType);
        return Ok(entity);
    }
}
