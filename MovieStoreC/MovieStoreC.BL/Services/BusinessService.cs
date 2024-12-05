using MovieStoreC.BL.Interfaces;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.Models.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<MovieFullDetails> GetAllMovies()
        {
            var result = new List<MovieFullDetails>();
            var movies = _movieRepository.GetAll();

            foreach (var  movie in movies)
            {
                var detailedMovie = new MovieFullDetails()
                {
                    Id=movie.Id,
                    Title=movie.Title,
                    Year=movie.Year,
                };
                foreach (var actorId in movie.Actors)
                {
                    var actor = _actorRepository.GetById(actorId);
                    if (actor == null) continue;
                    detailedMovie.Actors.Add(actor);
                                           
                }

                result.Add(detailedMovie);
            }        
            return result;
        }

    }
}
