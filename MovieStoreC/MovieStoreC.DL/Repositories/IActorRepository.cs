using MovieStoreC.DL.StaticData;
using MovieStoreC.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreC.DL.Repositories
{
    internal interface IActorRepository
    {
        public List<Actor> GetAll()
        {
            return StaticDb.Actor;
        }

        public Actor? GetById(int id)
        {
            if (id <= 0) return null;

            return StaticDb.Actor
                .FirstOrDefault(x => x.Id == id);
        }
    }
}
