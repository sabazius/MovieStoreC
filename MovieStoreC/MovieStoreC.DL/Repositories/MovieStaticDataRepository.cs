using MovieStoreC.DL.Interfaces;
using MovieStoreC.DL.StaticData;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Repositories
{
    internal class MovieStaticDataRepository : IMovieRepository
    {
        public List<Movie> GetAll()
        {
<<<<<<< HEAD
            return StaticDb.Movie;
        }

        public Movie? GetById(int id)
        {
            if (id <= 0) return null;

            return StaticDb.Movie
                .FirstOrDefault(x => x.Id == id);
=======
            return StaticDb.Movies;
        }
    }

    internal class MovieMongoRepository : IMovieRepository
    {
        public List<Movie> GetAll()
        {
            return StaticDb.Movies;
>>>>>>> 5aa0808bae28cbe8b1c2c36a9262fcf921944919
        }
    }
}
