using Microsoft.AspNetCore.Mvc;
using TheatreBoxOffice.Common.DTO.Token;
using TheatreBoxOffice.Common.DTO.User;

namespace TheatreBoxOffice.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public async Task<ActionResult<TokenDto>> Login([FromBody] LoginDto user)
    {
        throw new NotImplementedException();
    }

    [HttpPost("register")]
    public async Task<ActionResult<TokenDto>> Register([FromBody] RegisterDto user)
    {
        throw new NotImplementedException();
    }

    [HttpPost("register-manager")]
    public async Task<ActionResult<TokenDto>> RegisterManager([FromBody] RegisterDto user)
    {
        throw new NotImplementedException();
    }

    [HttpPost("logout")]
    public async Task<ActionResult> Logout([FromBody] string refreshToken)
    {
        throw new NotImplementedException();
    }
}
