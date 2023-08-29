using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using UygulamaHavuzu_1._0.Models;

namespace UygulamaHavuzu_1._0.Controllers


{
    public class HavaDurumuController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public HavaDurumuController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            string apiKey = "b1ded651a30f8840194a8ae16154d8e8";
            string cityName = "Ankara"; // İstediğiniz şehir adını buraya ekleyin
            string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}";

            HttpClient client = _httpClientFactory.CreateClient();

            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var weatherDataJson = await response.Content.ReadAsStringAsync();
                var weatherData = Newtonsoft.Json.JsonConvert.DeserializeObject<WeatherModels>(weatherDataJson);
                return View(weatherData);
            }
            else
            {
                return Content("API request failed.");
            }
        }
       
        public IActionResult HavaDurumuApp()
        {
            return View();
        }
    }
}
