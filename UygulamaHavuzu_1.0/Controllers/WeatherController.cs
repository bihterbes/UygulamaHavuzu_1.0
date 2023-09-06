using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UygulamaHavuzu_1._0.Models;

namespace UygulamaHavuzu_1._0.Controllers
{
    public class WeatherController : Controller
    {


        public async Task<IActionResult> Index()
        {
            var apiKey = "b1ded651a30f8840194a8ae16154d8e8";
            var CityWeathers = new List<WeatherModel>();
            List<string> Cities = new List<string>();
            Cities.Add("Roma");
            Cities.Add("Amerika");
            Cities.Add("Berlin");
            Cities.Add("Milano");
            var _httpClient = new HttpClient();
            foreach (var cityname in Cities)
            {
                var response = await _httpClient.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={cityname}&appid={apiKey}&&lang=tr");
                var WeatherJson = await response.Content.ReadAsStringAsync();
                var CityObject = WeatherModel.FromJson(WeatherJson);
                CityWeathers.Add(CityObject);
            }
            return View(CityWeathers);
        }


    }
}
