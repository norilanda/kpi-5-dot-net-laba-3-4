namespace TheatreBoxOffice.Common.DTO.User;

public record UserDto
{
    public long Id { get; init; }
    public string Email { get; init; } = string.Empty;
}
