using Ardalis.Specification;

namespace TheatreBoxOffice.DAL.Interfaces;

public interface IGenericRepository<T> : IRepositoryBase<T> where T : class
{
}
