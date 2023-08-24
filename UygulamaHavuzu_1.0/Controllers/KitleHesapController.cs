using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UygulamaHavuzu_1._0.Models;

namespace UygulamaHavuzu_1._0.Controllers
{
    public class KitleHesapController : Controller
    {
        [HttpGet] // Varsayılan HTTP GET isteği
        public IActionResult IndeksHesapla()
        {
            return View();
        }
        public IActionResult IndeksHesapla(BmiModel model)
        {
            double weight = model.Kilo; // Modelden ağırlık değerini al
            double height = model.Boy; // Modelden boy değerini al

            // Hesaplama işlemleri
            double heightInMeters = height / 100.0;
            double bmi = weight / (heightInMeters * heightInMeters);

            // Hesap sonucunu ViewData'ya ekleyerek View'e gönder
            ViewData["BMIResult"] = bmi;

            return View();


        }
       
        
    }
}
