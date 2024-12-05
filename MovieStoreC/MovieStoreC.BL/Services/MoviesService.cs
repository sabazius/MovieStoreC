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

<<<<<<< HEAD
        public void Add(Movie movie)
        {
            //_movieRepository.Add(movie);
        }

=======
>>>>>>> 5aa0808bae28cbe8b1c2c36a9262fcf921944919
        public List<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }
<<<<<<< HEAD

        public Movie? GetById(int id)
        {
            if (id <= 0) return null;

            return _movieRepository.GetById(id);
        }
=======
>>>>>>> 5aa0808bae28cbe8b1c2c36a9262fcf921944919
    }
}
