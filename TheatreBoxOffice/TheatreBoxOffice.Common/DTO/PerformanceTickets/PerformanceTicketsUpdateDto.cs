namespace TheatreBoxOffice.Common.DTO.PerformanceTickets;

public record PerformanceTicketsUpdateDto (
    int SeatCategoryId,
    decimal Price);
