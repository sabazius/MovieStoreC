using MovieStoreC.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreC.Models.Requests
{
    public class MovieFullDetails
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public int Year { get; set; }
        public List<Actor> Actors { get; set; } = new List<Actor>();

        public static implicit operator ValidationException(MovieFullDetails v)
        {
            throw new NotImplementedException();
        }
    }
}
