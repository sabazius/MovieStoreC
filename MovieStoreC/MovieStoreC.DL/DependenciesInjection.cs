using Microsoft.Extensions.DependencyInjection;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.DL.Repositories;

namespace MovieStoreC.DL
{
    public static class DependenciesInjection
    {
        public static IServiceCollection 
            RegisterRepositories(this IServiceCollection services)
        {
            return 
                services.AddSingleton<IMovieRepository,
                    MovieStaticDataRepository>();
        }
    }
}
