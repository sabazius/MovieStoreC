namespace MovieStoreC.Models.DTO
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public int Year { get; set; }

        public List<int>Actors{ get; set; }

        public List<Movie> Movies { get; set; }
    }
}
