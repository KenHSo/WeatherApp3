using WeatherApp3;

public class WeatherService
{
    private readonly HttpClient _httpClient;

    public WeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<WeatherForecast> GetWeatherForecastAsync(string cityName)
    {
        var apiKey = ""; // Replace with your API key
        var apiUrl = $"https://api.openweathermap.org/data/2.5/forecast?q={cityName}&appid={apiKey}&units=metric";

        var response = await _httpClient.GetFromJsonAsync<WeatherForecast>(apiUrl);
        return response;
    }
}

