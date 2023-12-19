using AutoMapper;
using TheatreBoxOffice.DAL.Entities;

namespace TheatreBoxOffice.BLL.MappingProfiles;

public class GenreProfile : Profile
{
    public GenreProfile()
    {
        CreateMap<string, Genre>()
            .ForMember(x => x.Name, opt => opt.MapFrom(src => src));

        CreateMap<Genre, String>().ConvertUsing(r => r.Name);
    }
}
