using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UygulamaHavuzu_1._0.Models;
using Newtonsoft.Json;
using System.IO;
using System.Net.Http;

namespace UygulamaHavuzu_1._0.Controllers
{
    public class OzluSozController : Controller
    {
       
        public IActionResult OzluSozApp()
        {
            return View();
        }

   

        public JsonResult GetQuoteFromJsonFile()
        {
            string wwwrootPath = Directory.GetCurrentDirectory(); // Projenin ana dizini
            string jsonFilePath = Path.Combine(wwwrootPath, "wwwroot", "json", "quotesData.json");

            if (System.IO.File.Exists(jsonFilePath))
            {
                string jsonData = System.IO.File.ReadAllText(jsonFilePath);
                List<Quotes> quotesList = JsonConvert.DeserializeObject<List<Quotes>>(jsonData);

                return Json(quotesList);
            }
            else
            {
                return Json(new List<Quotes>());
            }
        }

        //düzelt json file liste

    }
}
