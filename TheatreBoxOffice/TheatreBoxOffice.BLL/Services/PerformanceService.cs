using Ardalis.Specification;
using AutoMapper;
using TheatreBoxOffice.BLL.Exceptions;
using TheatreBoxOffice.BLL.Interfaces;
using TheatreBoxOffice.BLL.Specifications.PerformanceSpecs;
using TheatreBoxOffice.Common.DTO.Author;
using TheatreBoxOffice.Common.DTO.Performance;
using TheatreBoxOffice.DAL.Entities;
using TheatreBoxOffice.DAL.Interfaces;

namespace TheatreBoxOffice.BLL.Services;

public class PerformanceService : IPerformanceService
{
    private readonly IGenericRepository<Performance> _performanceRepository;
    private readonly IGenericRepository<Author> _authorRepository;
    private readonly IGenericRepository<Genre> _genreRepository;
    private readonly IMapper _mapper;

    public PerformanceService(IMapper mapper, 
        IGenericRepository<Performance> performanceRepository,
        IGenericRepository<Author> authorRepository,
        IGenericRepository<Genre> genreRepository
        )
    {
        _performanceRepository = performanceRepository;
        _mapper = mapper;
        _authorRepository = authorRepository;
        _genreRepository = genreRepository;
    }

    public async Task<PerformanceDto> CreateAsync(PerformanceCreateDto newPerformanceDto)
    {
        var performance = _mapper.Map<Performance>( newPerformanceDto );

        var authors = await GetOrCreateAuthors(newPerformanceDto.Authors);
        var genres = await GetOrCreateGenres(newPerformanceDto.Genres);

        performance.Authors = authors;
        performance.Genres = genres;

        await _performanceRepository.AddAsync( performance );
        await _performanceRepository.SaveChangesAsync();

        return await GetById(performance.Id);
    }

    public async Task<PerformanceDto> UpdateAsync(PerformanceUpdateDto newPerformanceDto)
    {
        var entity = await _performanceRepository.GetByIdAsync( newPerformanceDto.Id )
            ?? throw ResponseException.NotFound();

        var performance = _mapper.Map( newPerformanceDto, entity ); // TODO: add updating collections
        

        //var newAuthors = _mapper.Map<List<Author>>(newPerformanceDto.Authors);
        //var newGenres = _mapper.Map<List<Genre>>(newPerformanceDto.Genres);

        //var authors = performance.Genres.IntersectBy(newGenres.Select(g => g.Name), g => g.Name);
        
        //

        //var authors = await GetOrCreateAuthors(newPerformanceDto.Authors);
        //var genres = await GetOrCreateGenres(newPerformanceDto.Genres);

        //performance.Authors = authors;
        //performance.Genres = genres;

        await _performanceRepository.UpdateAsync( performance );
        await _performanceRepository.SaveChangesAsync();

        return await GetById(performance.Id);
    }

    public async Task DeleteAsync(long id)
    {
        var entity = await _performanceRepository.GetByIdAsync( id )
            ?? throw ResponseException.NotFound();

        await _performanceRepository.DeleteAsync(entity);
    }

    public async Task<PerformanceDto> GetByIdAsync(long id)
    {
        var spec = new PerformanceSpec(id);

        var entity = await _performanceRepository.FirstOrDefaultAsync(spec) 
            ?? throw ResponseException.NotFound();

        return _mapper.Map<PerformanceDto>(entity); 
    }

    public async Task<IEnumerable<PerformanceDto>> GetFilteredPerformancesAsync(PerformanceFilterDto filter)
    {
        var spec = new PerformanceSpec(filter);

        var entities = await _performanceRepository.ListAsync(spec);

        return _mapper.Map<IEnumerable<PerformanceDto>>(entities);
    }


    // private 
    private async Task<PerformanceDto> GetById(long id)
    {
        var createdPerformance = await _performanceRepository.GetByIdAsync( id );
        return _mapper.Map<PerformanceDto>( createdPerformance );
    }

    private async Task<List<Author>> GetOrCreateAuthors(List<AuthorDto> authorDtos)
    {
        var specFactory = (AuthorDto author) => new AuthorSpec(author);

        List<Author> authors = await GetOrCreateEntities(authorDtos, _authorRepository, specFactory);

        return authors;
    }

    private async Task<List<Genre>> GetOrCreateGenres(List<string> genreDtos)
    {
        var specFactory = (string genre) => new GenreSpec(genre);

        List<Genre> genres = await GetOrCreateEntities(genreDtos, _genreRepository, specFactory);

        return genres;
    }

    private async Task<List<TEntity>> GetOrCreateEntities<TEntity, TEntityDto> (List<TEntityDto> entityDtos, IGenericRepository<TEntity> repository, Func<TEntityDto, Specification<TEntity>> specFactory ) where TEntity : class
    {
        List<TEntity> entities = new();

        foreach (var entity in entityDtos)
        {
            var spec = specFactory(entity);
            var existingEntity = await repository.FirstOrDefaultAsync(spec);

            if (existingEntity == null)
            {
                existingEntity = _mapper.Map<TEntity>(entity);
                await repository.AddAsync(existingEntity);
            }

            entities.Add(existingEntity);
        }
        return entities;
    }
}
