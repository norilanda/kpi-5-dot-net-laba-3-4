namespace TheatreBoxOffice.DAL.Entities.Abstract;

public class BaseEntity<T>
{
    public T Id { get; set; } = default!;
}
