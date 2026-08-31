using Movies.Context;

namespace Movies.Core;

public static class DependencyInjectionConfig
{
    public static IServiceCollection ResolveDependencies(this IServiceCollection services)
    {
        services.AddScoped<MoviesContext>();

        return services;
    }
}