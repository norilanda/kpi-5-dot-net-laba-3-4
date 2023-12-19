namespace TheatreBoxOffice.Common.DTO.Performance;

public record PerformanceFilterDto
{
    public string? Name { get; init; }
    public string? AuthorFirstName { get; init; }
    public string? AuthorLastName { get; init; }
    public string? Genre { get; init; }
    public DateTime? Date { get; init; }
}
