using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.StaticData
{
    internal static class StaticDb
    {
<<<<<<< HEAD

        public static List<Actor> Actor { get; set;} = new List<Actor>()
        {
            new Actor()
            {
                Id = 1,
                Title = "Actor1",
            },
            new Actor()
            {
                Id = 2,
                Title = "Actor2",
            },
            new Actor()
            {
                Id = 3,
                Title = "Actor3",
            }
        };
        public static List<Movie> Movie { get; set; } = new List<Movie>()
=======
        public static List<Movie> Movies { get; set; } = new List<Movie>()
>>>>>>> 5aa0808bae28cbe8b1c2c36a9262fcf921944919
        {
            new Movie()
            {
                Id = 1,
                Title = "Test",
                Year = 2016
            },
            new Movie()
            {
                Id = 2,
                Title = "Test2",
                Year = 2017
            },
            new Movie()
            {
                Id = 3,
                Title = "Test3",
                Year = 2018
            }
        };

    }
}
