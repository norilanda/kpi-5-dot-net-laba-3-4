using TheatreBoxOffice.Common.DTO.Author;

namespace TheatreBoxOffice.Common.DTO.Performance;

public record PerformanceDto
{
    public long Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public DateTime Date { get; init; }
    public List<AuthorDto> Authors { get; init; } = default!;
    public List<string> Genres { get; init; } = default!;
}
