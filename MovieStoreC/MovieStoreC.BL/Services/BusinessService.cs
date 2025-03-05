using MovieStoreC.BL.Interfaces;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.Models.DTO;
using MovieStoreC.Models.Responses;

namespace MovieStoreC.BL.Services
{
    internal class BusinessService : IBusinessService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IActorRepository _actorRepository;

        public BusinessService(
            IMovieRepository movieRepository,
            IActorRepository actorRepository)
        {
            _movieRepository = movieRepository;
            _actorRepository = actorRepository;
        }

        public async Task<List<MovieFullDetailsResponse>> GetAllMovies()
        {
            var result = new List<MovieFullDetailsResponse>();

            var movies = await _movieRepository.GetAll();

            foreach (var movie in movies)
            {
                var detailedMovie = new MovieFullDetailsResponse()
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Year = movie.Year
                };

                //var tasks = new List<Task<Actor>>();

                //foreach (var actorId in movie.Actors)
                //{
                //    var t = _actorRepository.GetById(actorId);

                //    tasks.Add(t);
                //}

                //var actors = await Task.WhenAll(tasks);

                var actors = await _actorRepository.GetAll(movie.Actors);

                if (actors == null || !actors.Any()) continue;

                detailedMovie.Actors = actors;

                result.Add(detailedMovie);
            }

            return result;
        }
    }
}
