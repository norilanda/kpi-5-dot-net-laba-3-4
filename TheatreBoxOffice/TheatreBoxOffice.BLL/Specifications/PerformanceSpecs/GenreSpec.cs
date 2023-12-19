using TheatreBoxOffice.DAL.Entities;
using Ardalis.Specification;

namespace TheatreBoxOffice.BLL.Specifications.PerformanceSpecs;

public class GenreSpec : Specification<Genre>
{
    public GenreSpec(string genre)
    {
           Query.Where(g => g.Name == genre);
    }
}
