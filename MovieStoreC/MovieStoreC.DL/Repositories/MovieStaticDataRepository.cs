using MovieStoreC.DL.Interfaces;
using MovieStoreC.DL.StaticData;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Repositories
{
    internal class MovieStaticDataRepository : IMovieRepository
    {
        public List<Movie> GetAll()
        {
            return StaticDb.Movies;
        }
    }

    internal class MovieMongoRepository : IMovieRepository
    {
        public List<Movie> GetAll()
        {
            return StaticDb.Movies;
        }
    }
}
