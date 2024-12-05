using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
<<<<<<< HEAD
        Movie? GetById(int id);

    }
}

public interface IActorRepository
{
    List<Actor> GetAll();
    object GetAll(object actorId);
    Actor? GetById(int id);
    object GetById(object actorId);
}
=======
    }
}
>>>>>>> 5aa0808bae28cbe8b1c2c36a9262fcf921944919
