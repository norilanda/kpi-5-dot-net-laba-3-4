using Ardalis.Specification;
using TheatreBoxOffice.Common.DTO.Author;
using TheatreBoxOffice.DAL.Entities;

namespace TheatreBoxOffice.BLL.Specifications.PerformanceSpecs;

public class AuthorSpec : Specification<Author>
{
    public AuthorSpec(AuthorDto authorDto)
    {
           Query.Where(a => a.FirstName == authorDto.FirstName 
           &&  a.LastName == authorDto.LastName);
    }
}
