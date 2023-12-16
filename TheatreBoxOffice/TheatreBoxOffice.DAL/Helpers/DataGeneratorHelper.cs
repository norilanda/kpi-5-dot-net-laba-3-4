using Bogus;
using TheatreBoxOffice.DAL.Entities;

namespace TheatreBoxOffice.DAL.Helpers;

internal static class DataGeneratorHelper
{
    private const int _authorNumber = 3;

    private const int _genreNumber = 5;

    private const int _performancesNumber = 5;

    private const int _userNumber = 3;

    private const int _seatCategoryNumber = 4;

    private const int _seatInOneCategoryNumber = 5;


    private const int _startId = 1;

    public static IEnumerable<Author> GenerateAuthors()
    {
        int count = _startId;

        var faker = new Faker<Author>()
            .RuleFor(t => t.Id, _ =>  count++)
            .RuleFor(t => t.FirstName, f => f.Name.FirstName())
            .RuleFor(t => t.LastName, f => f.Name.LastName())
            ;

        return faker.Generate(_authorNumber);
    }

    public static IEnumerable<Genre> GenerateGenres()
    {
        int count = _startId;

        var faker = new Faker<Genre>()
            .RuleFor(t => t.Id, _ =>  count++)
            .RuleFor(t => t.Name, f => f.Music.Genre())
            ;

        return faker.Generate(_genreNumber);
    }

    public static IEnumerable<Seat> GenerateSeats()
    {
        int count = _startId;

        List<Seat> Seats = new();

        for (int i = 1; i <= _seatCategoryNumber; i++)
        {
            var faker = new Faker<Seat>()
                .RuleFor(t => t.Id, _ =>  count)
                .RuleFor(t => t.SeatCategory, _ => i)
                .RuleFor(t => t.Row, _ => i)
                .RuleFor(t => t.Number, _ => count++)
                ;
            Seats.AddRange(faker.Generate(_seatInOneCategoryNumber));
        }

        return Seats;
    }

    public static IEnumerable<Performance> GeneratePerformances()
    {
        int count = _startId;

        var faker = new Faker<Performance>()
            .RuleFor(t => t.Id, _ =>  count++)
            .RuleFor(t => t.Name, f => f.Name.JobTitle())
            .RuleFor(t => t.Date, f => f.Date.Future())
            ;

        return faker.Generate(_performancesNumber);
    }
}
