using Shared.Contracts;

namespace Web.Services;

public sealed class ApiService(HttpClient client, ILogger<ApiService> logger)
{
    public async Task<WeatherForecast[]> GetWeatherAsync()
    {
        try
        {
            return await client.GetFromJsonAsync<WeatherForecast[]>("weatherforecast") ?? [];
        }
        catch (Exception e)
        {
            logger.LogError(e, "Failed to get weather");
            throw;
        }
    }
}
