using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheatreBoxOffice.Common.DTO.Seat;

namespace TheatreBoxOffice.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "Manager")]

public class SeatCategoryController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult> Create([FromBody] List<SeatCategoryCreateDto> seatCategory)
    {
        throw new NotImplementedException();
    }
}
