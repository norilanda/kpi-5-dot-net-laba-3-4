using TheatreBoxOffice.Common.DTO.Seat;

namespace TheatreBoxOffice.BLL.Interfaces;

public interface ISeatCategoryService
{
    public Task CreateSeatCategoryAsync(List<SeatCategoryCreateDto> seatCategoryDto);
}
