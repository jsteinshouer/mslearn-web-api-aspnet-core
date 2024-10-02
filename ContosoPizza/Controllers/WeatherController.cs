using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherController : ControllerBase
{

    private HttpClient _httpClient;
    private string _apiKey;

    public WeatherController(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _apiKey = Environment.GetEnvironmentVariable("WEATHER_API_KEY");
    }

    [HttpGet("{zip}")]
    public async Task<IActionResult> Get(string zip)
    {
        var data =  await _httpClient.GetFromJsonAsync<Object>($"https://api.openweathermap.org/data/2.5/weather?zip={zip},US&units=imperial&appid={_apiKey}");
        return Ok(data);
    }

}
