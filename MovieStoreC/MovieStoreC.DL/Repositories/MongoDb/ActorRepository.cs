using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Repositories.MongoDb
{
    internal class ActorRepository : IActorRepository
    {
        public List<Actor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Actor? GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
