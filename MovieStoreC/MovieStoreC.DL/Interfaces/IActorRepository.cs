using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Interfaces
{
    public interface IActorRepository
    {
        Task<List<Actor>> GetAll();

        Task<Actor?> GetById(string id);
    }
}
