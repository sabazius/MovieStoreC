using Microsoft.Extensions.DependencyInjection;
using MovieStoreC.BL.Interfaces;
using MovieStoreC.BL.Services;

namespace MovieStoreC.BL
{
    public static class DependenciesInjection
    {
        public static IServiceCollection
            RegisterServices(this IServiceCollection services)
        {
            return services
                        .AddSingleton<IMoviesService, MoviesService>()
                        .AddSingleton<IBusinessService, BusinessService>();
        }
    }
}
