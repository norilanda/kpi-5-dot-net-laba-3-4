﻿﻿using Ardalis.Specification.EntityFrameworkCore;
using TheatreBoxOffice.DAL.Interfaces;
using TheatreBoxOffice.DAL.Context;
namespace TheatreBoxOffice.DAL.Repositories;

public class EfRepository<T> : RepositoryBase<T>, IGenericRepository<T> where T : class
{
    public EfRepository(TheatreBoxOfficeContext dbContext) : base(dbContext)
    {
    }
}
