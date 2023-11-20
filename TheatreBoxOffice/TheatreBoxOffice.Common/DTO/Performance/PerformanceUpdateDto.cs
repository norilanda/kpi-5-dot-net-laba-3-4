using TheatreBoxOffice.Common.DTO.Author;

namespace TheatreBoxOffice.Common.DTO.Performance;

public class PerformanceUpdateDto
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public List<AuthorDto> Authors { get; set; } = default!;
    public List<string> Genres { get; set; } = default!;
}
