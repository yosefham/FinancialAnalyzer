using Microsoft.Extensions.DependencyInjection;

namespace AlphaVantageClient;

public static class AlphaVantageClientModule
{
    public static IServiceCollection AddAlphaVantage(this IServiceCollection services)
    {
        services.AddSingleton<AlphaVantageService>();
        // services.AddHttpClient()
        return services;
    }
}