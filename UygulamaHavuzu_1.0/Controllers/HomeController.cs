using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UygulamaHavuzu_1._0.Models;

namespace UygulamaHavuzu_1._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Models.ContentModel obj;
            List<Models.ContentModel> lobj = new List<ContentModel>();

            obj = new ContentModel();
            obj.title = "BMI Calculator";
            obj.text = "Calculate your estimated body fat percentage using Body Mass Index!";
            obj.img = "/css/kitle indeksi.jpg";
            obj.kontrol = "HomeController1";
            obj.aksiyon = "Index";

            lobj.Add(obj);

            obj = new ContentModel();
            obj.title = "Random Quotes";
            obj.text = "Browse of collection of random quotes to give you inspiration and share";
            obj.img = "/css/kitaplar3.jpg";
            obj.kontrol = "ozlusoz";
            obj.aksiyon = "ozlusozapp";

            lobj.Add(obj);

            obj = new ContentModel();
            obj.title = "To-Do App";
            obj.text = "A simple to do list app to manage your daily life tasks. Create your own list!";
            obj.img = "/css/todoResim3.jpg";
            obj.kontrol = "liste";
            obj.aksiyon = "todoapp";

            lobj.Add(obj);

            obj = new ContentModel();
            obj.title = "Weather App";
            obj.text = "The Weather Channel provide local weather forecast for cities, check now";
            obj.img = "/css/havadurumu3.jpg";
            obj.kontrol = "havadurumu";
            obj.aksiyon = "Index";

            lobj.Add(obj);

            return View(lobj);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
      
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
