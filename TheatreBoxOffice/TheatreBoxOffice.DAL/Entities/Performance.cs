using TheatreBoxOffice.DAL.Entities.Abstract;

namespace TheatreBoxOffice.DAL.Entities;

public class Performance : BaseEntity<long>
{
    public string Name { get; set; } = string.Empty;
    public DateTime Date { get; set; }

    public ICollection<Author> Authors { get; set; } = new List<Author>();
    public ICollection<Genre> Genres { get; set; } = new List<Genre>();
    public ICollection<TicketPriceType> TicketPriceTypes { get; set; } = new List<TicketPriceType>();
}
