using MovieStoreC.Models.DTO;

namespace MovieStoreC.BL.Interfaces
{
    public interface IMoviesService
    {
        Task<List<Movie>> GetAll();

        Task<Movie?> GetById(string id);

        Task Add(Movie movie);

        Task AddActorToMovie(string movieId, string actor);
    }
}
