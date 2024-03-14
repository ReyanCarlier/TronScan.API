using Microsoft.Extensions.DependencyInjection;

namespace TronScan.API;

public static class ServiceCollectionExtensions
{
    public static void AddTronScanApi(this IServiceCollection services, string tronScanApiKey)
    {
        services.AddScoped<ITronScanService>(sp => new TronScanService(sp.GetRequiredService<HttpClient>(), tronScanApiKey));
    }
}