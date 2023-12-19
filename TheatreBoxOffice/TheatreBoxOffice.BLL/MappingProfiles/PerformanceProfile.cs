using AutoMapper;
using TheatreBoxOffice.Common.DTO.Performance;
using TheatreBoxOffice.DAL.Entities;

namespace TheatreBoxOffice.BLL.MappingProfiles;

public class PerformanceProfile : Profile
{
    public PerformanceProfile()
    {
        CreateMap<Performance, PerformanceDto>();

        CreateMap<PerformanceCreateDto, Performance>()
            .ForMember(x => x.Authors, opt => opt.Ignore())
            .ForMember(x => x.Genres, opt => opt.Ignore());

        CreateMap<PerformanceUpdateDto, Performance>()
            .ForMember(x => x.Authors, opt => opt.Ignore())
            .ForMember(x => x.Genres, opt => opt.Ignore());
    }
}
