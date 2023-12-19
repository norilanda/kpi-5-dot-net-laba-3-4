namespace TheatreBoxOffice.Common.DTO.User;

public record UserDto
{
    public string Id { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
}
