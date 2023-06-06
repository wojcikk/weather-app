using Microsoft.AspNetCore.Mvc;
using weather_app_core.Connection;
using weather_app_core.Models;

namespace weather_app_core.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherApiConnection weatherApiConnection;

        public WeatherForecastController(IWeatherApiConnection weatherApiConnection)
        {
            this.weatherApiConnection = weatherApiConnection;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<string> GetWeatherForecast()
        {
            var response = await weatherApiConnection.SendRequest("https://api.weatherapi.com/v1/forecast.json?q=Warsaw&days=7&key=a5838f45011b45d1983155628230506%20");

            return response.ToString();
        }
    }
}