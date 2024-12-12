using MovieStoreC.Models.DTO;

namespace MovieStoreC.Models.Responses
{
    public class MovieFullDetailsResponse
    {
        public string Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public int Year { get; set; }

        public List<Actor> Actors { get; set; } = new List<Actor>();
    }
}
