using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Interfaces
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAll();

        Task<Movie?> GetById(string id);

        Task Add(Movie movie);

        Task Update(Movie movie);
    }
}
