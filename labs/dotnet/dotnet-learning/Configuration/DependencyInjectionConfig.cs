using DotNetLearning.Services;

namespace DotNetLearning.Configuration;

public static class DependencyInjectionConfig
{
    public static IServiceCollection ResolveDepencies(this IServiceCollection services)
    {
        services.AddTransient<TestDIService>();

        return services;
    }
}