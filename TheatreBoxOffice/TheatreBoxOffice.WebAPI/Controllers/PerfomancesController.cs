using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TheatreBoxOffice.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfomancesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetFilteredPerformances()
        {
            return Ok();
        }
    }
}
