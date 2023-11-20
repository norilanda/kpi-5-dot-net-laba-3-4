namespace TheatreBoxOffice.Common.DTO.PerformanceTickets;

public record TicketsCreationResult
{
    public List<long> CreatedTicketsIds { get; init; } = default!;
    public List<int> FailedTicketsSeats { get; init; } = default!;
}
