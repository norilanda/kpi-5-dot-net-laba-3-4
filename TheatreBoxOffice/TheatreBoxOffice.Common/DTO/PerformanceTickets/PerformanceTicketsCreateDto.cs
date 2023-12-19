namespace TheatreBoxOffice.Common.DTO.PerformanceTickets;

public record PerformanceTicketsCreateDto (
    int SeatCategoryId,
    decimal Price);
