using MovieStoreC.Models.Responses;

namespace MovieStoreC.BL.Interfaces
{
    public interface IBusinessService
    {
        Task<List<MovieFullDetailsResponse>> GetAllMovies();
    }
}
