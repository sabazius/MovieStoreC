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

        public async Task<List<Movie>> GetAll()
        {
            try
            {
                return await _moviesCollection.Find(m => true).ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to retrieve movies");
                return new List<Movie>();
            }
        }

        public async Task<Movie?> GetById(string id)
        {
            try
            {
                return await _moviesCollection
                    .Find(m => m.Id == id)
                    .FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to retrieve movie by id");
                return null;
            }
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
                await _moviesCollection.InsertOneAsync(movie);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to add movie");
            }
        }

        public async Task Update(Movie movie)
        {
            try
            {
                await _moviesCollection.ReplaceOneAsync(m => m.Id == movie.Id, movie);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to update movie");
            }
        }
    }
}
