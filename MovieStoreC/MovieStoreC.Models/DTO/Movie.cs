namespace MovieStoreC.Models.DTO
{
    public class Movie
    {
        public string Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public int Year { get; set; }

        public List<string> Actors { get; set; }
    }
}
