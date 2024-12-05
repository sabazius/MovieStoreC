using MovieStoreC.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreC.BL.Interfaces
{
    public interface IBusinessService
    {
        List<MovieFullDetails> GetAllMovies();
    }
}
