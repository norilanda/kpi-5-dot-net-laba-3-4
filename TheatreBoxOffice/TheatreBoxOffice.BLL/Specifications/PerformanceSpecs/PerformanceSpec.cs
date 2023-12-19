using Ardalis.Specification;
using TheatreBoxOffice.Common.DTO.Performance;
using TheatreBoxOffice.DAL.Entities;

namespace TheatreBoxOffice.BLL.Specifications.PerformanceSpecs;

public class PerformanceSpec : Specification<Performance>
{
    public PerformanceSpec(long id)
    {
        Query.Where(p => p.Id == id)
            .Include(p => p.Authors)
            .Include(p => p.Genres);
    }

    public PerformanceSpec(PerformanceFilterDto filter)
    {
        if (filter.Name != null)
            Query.Where(p => p.Name == filter.Name);

        if (filter.AuthorFirstName != null && filter.AuthorLastName != null)
            Query.Where(p => p.Authors.Any(a => a.FirstName == filter.AuthorFirstName && a.LastName == filter.AuthorLastName));

        if (filter.AuthorFirstName != null)
            Query.Where(p => p.Authors.Any(a => a.FirstName == filter.AuthorFirstName));

        if (filter.AuthorLastName != null)
            Query.Where(p => p.Authors.Any(a => a.LastName == filter.AuthorLastName));

        if (filter.Genre != null)
            Query.Where (p => p.Genres.Any(g => g.Name == filter.Genre));

        if (filter.Date != null)
            Query.Where(p => p.Date == filter.Date);

        Query
            .Include(p => p.Authors)
            .Include(p => p.Genres);
    }
}
