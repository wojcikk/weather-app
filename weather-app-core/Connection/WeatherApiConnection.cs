using Microsoft.Extensions.Options;
using System.Net.Http;

namespace weather_app_core.Connection
{
    public class WeatherApiConnection : IWeatherApiConnection
    {
        private readonly HttpClient _httpClient;
        private readonly string _weatherApiLinkBase = string.Empty;

        public string WeatherApiLinkBase => _weatherApiLinkBase;

        public WeatherApiConnection(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _weatherApiLinkBase = "https://api.weatherapi.com/v1/";
        }

        public async Task<string> SendRequest(string link)
        {
            HttpRequestMessage request = new(HttpMethod.Get, link);
            HttpResponseMessage response = await _httpClient.SendAsync(request);
            HttpContent responseContent = response.Content;
            string responseContentSerialized = await responseContent.ReadAsStringAsync();
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            return responseContentSerialized;
        }
    }
}