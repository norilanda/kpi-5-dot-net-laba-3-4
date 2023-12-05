namespace TheatreBoxOffice.Common.DTO.PerformanceTickets;

public record PerformanceTicketsCreateDto (
    long SeatCategory,
    decimal Price);
