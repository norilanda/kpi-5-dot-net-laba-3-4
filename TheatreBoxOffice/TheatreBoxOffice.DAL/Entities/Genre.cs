using TheatreBoxOffice.DAL.Entities.Abstract;

namespace TheatreBoxOffice.DAL.Entities;

public class Genre : BaseEntity<int>
{
    public string Name { get; set; } = string.Empty;

    public ICollection<Performance> Performances { get; set; } = new List<Performance>();
}
