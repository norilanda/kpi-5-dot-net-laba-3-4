﻿namespace TheatreBoxOffice.Common.DTO.User;

public record RegisterDto
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
