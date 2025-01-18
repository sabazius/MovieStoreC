using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();

        Movie? GetById(string id);

        void Add(Movie movie);

        void Update(Movie movie);
    }
}
