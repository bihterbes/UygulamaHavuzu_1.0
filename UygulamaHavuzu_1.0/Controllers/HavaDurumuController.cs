using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using UygulamaHavuzu_1._0.Models;
using Newtonsoft.Json.Linq;

namespace UygulamaHavuzu_1._0.Controllers


{
    public class HavaDurumuController : Controller
    {

        private readonly HttpClient _httpClient;

        public HavaDurumuController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IActionResult> Index(string city)
        {
            //city = "New york";
            if (string.IsNullOrEmpty(city))
            {
                return View();
            }

            string apiKey = "b1ded651a30f8840194a8ae16154d8e8";
            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string jsonResult = await response.Content.ReadAsStringAsync();
                var weatherData = JObject.Parse(jsonResult);

                WeatherModels weatherModel = new WeatherModels
                {
                    City = weatherData["name"].ToString(),
                    Description = weatherData["weather"][0]["description"].ToString(),
                    Temperature = Convert.ToDouble(weatherData["main"]["temp"]),
                    Humidity = Convert.ToDouble(weatherData["main"]["humidity"]),
                    WindSpeed = Convert.ToDouble(weatherData["wind"]["speed"]),
                    WeatherIcon = weatherData["weather"][0]["icon"].ToString(),
                    LastUpdated = DateTime.Now
                };

                return View(weatherModel);
            }

            return View();
        }

        public IActionResult HavaDurumuApp()
        {
            return View();
        }
    }
}
