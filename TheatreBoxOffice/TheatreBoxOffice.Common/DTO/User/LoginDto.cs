namespace TheatreBoxOffice.Common.DTO.User;

public record LoginDto
{
    public string Email { get; init; } = string.Empty;
    public string Password { get; init; } = string.Empty;
}
