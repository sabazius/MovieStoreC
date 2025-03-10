using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.Models.Configurations;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Repositories.MongoDb
{
    internal class ActorMongoRepository : IActorRepository
    {
        private readonly IMongoCollection<Actor> _actorsCollection;
        private readonly ILogger<ActorMongoRepository> _logger;

        public ActorMongoRepository(
            IOptionsMonitor<MongoDbConfiguration> mongoConfig,
            ILogger<ActorMongoRepository> logger)
        {
            _logger = logger;

            var client =
                new MongoClient(mongoConfig.CurrentValue.ConnectionString);
            var database = client.GetDatabase(
                mongoConfig.CurrentValue.DatabaseName);
            _actorsCollection = database.GetCollection<Actor>("Actors");
        }

        public async Task<List<Actor>> GetAll()
        {
            try
            {
                // Asynchronously retrieving all actors
                return await _actorsCollection.Find(a => true).ToListAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to retrieve actors");
                return new List<Actor>();
            }
        }

        public async Task<Actor?> GetById(string id)
        {
            try
            {
                // Asynchronously retrieving an actor by ID
                return await _actorsCollection
                    .Find(a => a.Id == id)
                    .FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to retrieve actor by ID");
                return null;
            }
        }
    }
}
