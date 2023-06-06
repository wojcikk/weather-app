namespace weather_app_core.Connection
{
    public interface IWeatherApiConnection
    {
        string WeatherApiLinkBase { get; }
        Task<string> SendRequest(string link);
    }
}
