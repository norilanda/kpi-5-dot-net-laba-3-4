namespace TheatreBoxOffice.Common.DTO.Author;

public record AuthorDto()
{
    public string FirstName { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
}
