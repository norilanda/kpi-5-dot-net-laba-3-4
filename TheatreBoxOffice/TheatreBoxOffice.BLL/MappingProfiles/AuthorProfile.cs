using AutoMapper;
using TheatreBoxOffice.Common.DTO.Author;
using TheatreBoxOffice.DAL.Entities;

namespace TheatreBoxOffice.BLL.MappingProfiles;

public class AuthorProfile : Profile
{
    public AuthorProfile()
    {
        CreateMap<AuthorDto, Author>().ReverseMap();
    }
}
