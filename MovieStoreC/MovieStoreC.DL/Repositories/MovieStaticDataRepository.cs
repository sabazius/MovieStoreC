using MovieStoreC.DL.Interfaces;
using MovieStoreC.DL.StaticData;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Repositories
{
    internal class MovieStaticDataRepository : IMovieRepository
    {
        public List<Movie> GetAll()
        {
            return StaticDb.Movie;
        }

        public Movie? GetById(int id)
        {
            if (id <= 0) return null;

            return StaticDb.Movie
                .FirstOrDefault(x => x.Id == id);
        }
    }
}
