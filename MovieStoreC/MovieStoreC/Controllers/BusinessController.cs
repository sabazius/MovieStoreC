using Microsoft.AspNetCore.Mvc;
using MovieStoreC.BL.Interfaces;
using MovieStoreC.Models.DTO;
using MovieStoreC.Models.Requests;

namespace MovieStoreC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BusinessController : ControllerBase
    {
        private readonly IBusinessService _movieService;

        public BusinessController(IBusinessService movieService)

        {
            _movieService = movieService;
        }

        [HttpGet("GetAllDetailedMovies")]
        public IActionResult GetAllDetailedMovies()
        {
            var result =
                _movieService.GetAllMovies();

            if (result != null && result.Count > 0)
            {
                return Ok(result);
            }

            return NotFound();
        }

    }
}
