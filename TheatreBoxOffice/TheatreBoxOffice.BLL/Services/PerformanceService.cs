using TheatreBoxOffice.BLL.Interfaces;
using TheatreBoxOffice.Common.DTO.Performance;

namespace TheatreBoxOffice.BLL.Services;

public class PerformanceService : IPerformanceService
{
    public Task<PerformanceDto> CreateAsync(PerformanceCreateDto newPerformanceDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<PerformanceDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<PerformanceDto>> GetFilteredPerformancesAsync(PerformanceFilterDto filter)
    {
        throw new NotImplementedException();
    }

    public Task<PerformanceDto> UpdateAsync(PerformanceUpdateDto newPerformanceDto)
    {
        throw new NotImplementedException();
    }
}
