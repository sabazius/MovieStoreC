using DnsClient.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.Models.Configurations;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Repositories.MongoDb
{
    internal class MoviesMongoRepository : IMovieRepository
    {
        private readonly IMongoCollection<Movie> _moviesCollection;
        private readonly ILogger<MoviesMongoRepository> _logger;

        public MoviesMongoRepository(
            IOptionsMonitor<MongoDbConfiguration> mongoConfig,
            ILogger<MoviesMongoRepository> logger)
        {
            _logger = logger;

            var client =
                new MongoClient(mongoConfig.CurrentValue.ConnectionString);
            var database = client.GetDatabase(
                mongoConfig.CurrentValue.DatabaseName);
            _moviesCollection = database.GetCollection<Movie>("MoviesDb");
        }

        public async Task<List<Movie>> GetAll(int year)
        {
            var result = await _moviesCollection.FindAsync(m => m.Year == year);

            return await result.ToListAsync();
        }

        public async Task<List<Movie>> GetAll()
        {
            return _moviesCollection.Find(m => true)
                .ToList();
        }

        public Task<Movie?> GetById(string id)
        {
            return _moviesCollection
                .Find(m => m.Id == id)
                .FirstOrDefault();
        }

        public async Task Add(Movie? movie)
        {
            if (movie == null)
            {
                _logger.LogError("Movie is null");

                return;
            }

            try
            {
                _moviesCollection.InsertOne(movie);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to add movie");
            }
        }

        public void Update(Movie movie)
        {
            _moviesCollection.ReplaceOne(m => m.Id == movie.Id, movie);
        }
    }
}
