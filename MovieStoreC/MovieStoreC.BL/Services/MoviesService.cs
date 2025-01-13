using Microsoft.Extensions.Logging;
using MovieStoreC.BL.Interfaces;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.BL.Services
{
    internal class MoviesService : IMoviesService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly ILogger<MoviesService> _logger;

        public MoviesService(
            IMovieRepository movieRepository,
            ILogger<MoviesService> logger)
        {
            _movieRepository = movieRepository;
            _logger = logger;
        }

        public void Add(Movie movie)
        {
            if (movie == null)
            {
                _logger.LogError("Movie is null");
                return;
            }

            movie.Id = Guid.NewGuid().ToString();

            _movieRepository.Add(movie);

        }

        public List<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }

        public Movie? GetById(string id)
        {
            if (string.IsNullOrEmpty(id)) return null;

            return _movieRepository.GetById(id);
        }
    }
}
