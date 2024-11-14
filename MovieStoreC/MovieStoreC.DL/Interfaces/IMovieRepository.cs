using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
    }
}
