﻿namespace TheatreBoxOffice.Common.DTO.Token;

public record TokenDto
{
    public string AccessToken { get; init; } = string.Empty;
    //public string RefreshToken { get; init; } = string.Empty;
}
