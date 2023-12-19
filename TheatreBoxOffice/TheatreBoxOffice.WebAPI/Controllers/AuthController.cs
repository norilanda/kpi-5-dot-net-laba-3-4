using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheatreBoxOffice.BLL.Interfaces;
using TheatreBoxOffice.Common.DTO.Token;
using TheatreBoxOffice.Common.DTO.User;

namespace TheatreBoxOffice.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public async Task<ActionResult<TokenDto>> Login([FromBody] LoginDto user)
    {
        var token = await _authService.LoginAsync(user);
        return Ok(token);
    }

    [HttpPost("register")]
    public async Task<ActionResult<TokenDto>> Register([FromBody] RegisterDto user)
    {
        var token = await _authService.RegisterAsync(user);
        return Ok(token);
    }

    [HttpPost("register-manager")]
    public async Task<ActionResult<TokenDto>> RegisterManager([FromBody] RegisterDto user)
    {
        var token = await _authService.RegisterManagerAsync(user);
        return Ok(token);
    }
}
