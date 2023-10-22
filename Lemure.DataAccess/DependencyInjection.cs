using Lemure.Domain;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace Lemure.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddRepository(this IServiceCollection services)
    {
        services.AddScoped<BookmarkRepository>();
        return services;
    }

    public static IServiceCollection AddInfraLogging(this IServiceCollection services)
    {
        services.AddLogging(o => o.AddSerilog());
        return services;
    }

    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddRepository();
        services.AddInfraLogging();
        return services;
    }
}
