using Microsoft.Extensions.Logging;
using MovieStoreC.BL.Interfaces;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.Models.DTO;
using System.Runtime.CompilerServices;

namespace MovieStoreC.BL.Services
{
    internal class MoviesService : IMoviesService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IActorRepository _actorRepository;
        private readonly ILogger<MoviesService> _logger;

        public MoviesService(
            IMovieRepository movieRepository,
            ILogger<MoviesService> logger,
            IActorRepository actorRepository)
        {
            _movieRepository = movieRepository;
            _logger = logger;
            _actorRepository = actorRepository;
        }

        public async Task Add(Movie movie)
        {
            if (movie == null)
            {
                _logger.LogError("Movie is null");
                return;
            }

            movie.Id = Guid.NewGuid().ToString();

            await _movieRepository.Add(movie);
        }

        public void AddActorToMovie(string movieId, string actorId)
        {
            if (string.IsNullOrEmpty(movieId) || string.IsNullOrEmpty(actorId))
            {
                _logger.LogError("MovieId or Actor is null");
                return;
            }

            if (Guid.TryParse(movieId, out _) || Guid.TryParse(actorId, out _))
            {
                _logger.LogError("MovieId or Actor is not valid");
                return;
            }

            var movie = _movieRepository.GetById(movieId);

            if (movie == null)
            {
                _logger.LogError("Movie not found");
                return;
            }

            var actor = _actorRepository.GetById(actorId);

            if (actor == null)
            {
                _logger.LogError("Actor not found");
                return;
            }

            if (movie.Actors == null)
            {
                movie.Actors = new List<string>();
            }

            movie.Actors.Add(actorId);

            _movieRepository.Update(movie);
        }

        public List<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }

        public Movie? GetById(string id)
        {
            if (string.IsNullOrEmpty(id) || !Guid.TryParse(id, out _)) return null;

            return _movieRepository.GetById(id);
        }


    }
}
