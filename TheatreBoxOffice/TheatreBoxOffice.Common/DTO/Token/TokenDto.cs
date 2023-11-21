namespace TheatreBoxOffice.Common.DTO.Token;

public record TokenDto
{
    public string AccessToket { get; init; } = string.Empty;
    public string RefreshToket { get; init; } = string.Empty;
}
