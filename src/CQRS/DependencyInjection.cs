using Lemure.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Lemure.CQRS;

public static class DependencyInjection
{
    public static IServiceCollection AddCQRSLayerServices(this IServiceCollection services)
    {
        services
            .AddInfrastructure()
            .AddMediator();

        return services;
    }

    public static IServiceCollection AddMediator(this IServiceCollection services)
    {
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(typeof(MediatREntrypoint).Assembly);
        });
        return services;
    }
}
