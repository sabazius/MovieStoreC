using Microsoft.AspNetCore.Mvc;
using MovieStoreC.BL.Interfaces;
using MovieStoreC.Models.DTO;
using MovieStoreC.Models.Requests;
using System.Threading.Tasks;

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
        public async Task<IActionResult> GetAllDetailedMovies()
        {
            var result = await _movieService.GetAllMovies();

            if (result != null && result.Count > 0)  
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpPost("Test")]
        public async Task<IActionResult> Test([FromBody] TestRequest request)
        {
            // Assuming the service handles some logic here asynchronously
            // await _movieService.ProcessTestRequest(request); (Uncomment and modify this as necessary)

            return Ok();
        }
    }

    public class TestRequest
    {
        public int MagicNumber { get; set; }

        public string Text { get; set; }

        public DateTime DateTime { get; set; }
    }
}
