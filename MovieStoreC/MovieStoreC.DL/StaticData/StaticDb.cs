using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.StaticData
{
    internal static class StaticDb
    {
    //{
    //    public static List<Actor> Actors { get; set; } = new List<Actor>()
    //    {
    //        new Actor()
    //        {
    //            Id = 1,
    //            Name = "Actor1"
    //        },
    //        new Actor()
    //        {
    //            Id = 2,
    //            Name = "Actor2"
    //        },
    //        new Actor()
    //        {
    //            Id = 3,
    //            Name = "Actor3"
    //        }
    //    };

    public static List<Movie> Movies { get; set; } = new List<Movie>()
        {
            new Movie()
            {
                Id = "1",
                Title = "Test",
                Year = 2016,
                Actors = new List<string>(){"1", "2"}
            },
            new Movie()
            {
                Id = "2",
                Title = "Test2",
                Year = 2017,
                Actors = new List<string>(){"2", "3"}
            },
            new Movie()
            {
                Id = "3",
                Title = "Test3",
                Year = 2018,
                Actors = new List<string>(){"1", "3"}
            }
        };

    }
}
