namespace TheatreBoxOffice.Common.DTO.PerformanceTickets;

public record TicketsCreationResult
{
    public List<TicketsAggregatedDto> CreatedTickets { get; init; } = default!;
    public List<int> FailedTicketsSeats { get; init; } = default!;
}
