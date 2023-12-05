using TheatreBoxOffice.Common.DTO.Performance;

namespace TheatreBoxOffice.BLL.Interfaces;

public interface IPerformanceService
{
    public Task<PerformanceDto> GetByIdAsync(long id);
    public Task<PerformanceDto> UpdateAsync(PerformanceUpdateDto newPerformanceDto);
    public Task<PerformanceDto> CreateAsync(PerformanceCreateDto newPerformanceDto);
    public Task DeleteAsync(long id);
    public Task<IEnumerable<PerformanceDto>> GetFilteredPerformancesAsync(PerformanceFilterDto filter);
}
