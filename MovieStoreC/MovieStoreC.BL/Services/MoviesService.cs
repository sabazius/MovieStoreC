using MovieStoreC.BL.Interfaces;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.BL.Services
{
    internal class MoviesService : IMoviesService
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public List<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }
    }
}
