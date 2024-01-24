using Web.Services;

namespace Web.Extensions;

internal static class Extensions
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<ApiService>();
        services.AddHttpClient<ApiService>(cfg =>
        {
            cfg.BaseAddress = new Uri("http://localhost:5099/");
        });
        return services;
    }
}
