﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheatreBoxOffice.Common.DTO.Token;

namespace TheatreBoxOffice.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class TokensController : ControllerBase
{
    [HttpPost("refresh")]
    public async Task<ActionResult<TokenDto>> Refresh([FromBody] string refreshToken)
    {
        throw new NotImplementedException();
    }
}
