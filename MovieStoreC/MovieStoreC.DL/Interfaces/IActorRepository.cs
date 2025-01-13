using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Interfaces
{
    public interface IActorRepository
    {
        List<Actor> GetAll();

        Actor? GetById(string id);
    }
}
