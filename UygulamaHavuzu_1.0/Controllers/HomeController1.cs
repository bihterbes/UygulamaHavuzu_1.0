using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using UygulamaHavuzu_1._0.Models;

namespace UygulamaHavuzu_1._0.Controllers
{
    public class HomeController1 : Controller
    {
        private readonly ExampleModel _exampleModel;

        public HomeController1()
        {
            _exampleModel = new ExampleModel();
        }

        public IActionResult Index()
        {
            return View(_exampleModel);
        }
        [HttpPost]
        public IActionResult Hesapla(string deger1, string deger2)
        {
            double parsedDeger1, parsedDeger2;

            if (double.TryParse(deger1, out parsedDeger1) && double.TryParse(deger2, out parsedDeger2))
            {
                double deger2Metre = parsedDeger2 / 100.0; // 1 metre = 100 cm

                _exampleModel.Deger1 = parsedDeger1;
                _exampleModel.Deger2 = deger2Metre; // Metre cinsinde değeri modele atama

                double sonuc = parsedDeger1 / (deger2Metre * deger2Metre);

                ViewBag.Sonuc = sonuc.ToString("F2");

                string sonucDurumu;

                if (sonuc < 8)
                {
                    sonucDurumu = "İdeal kilonun altında";
                }
                else if (sonuc >= 8 && sonuc <= 24.9)
                {
                    sonucDurumu = "İdeal kiloda";
                }
                else if (sonuc >= 25 && sonuc <= 29.9)
                {
                    sonucDurumu = "İdeal kilonun üstünde";
                }
                else if (sonuc >= 30 && sonuc <= 39.9)
                {
                    sonucDurumu = "İdeal kilonun çok üstünde (obez)";
                }
                else if (sonuc > 39.9)
                {
                    sonucDurumu = "İdeal kilonun çok üstünde (morbid obez)";
                }
                else
                {
                    sonucDurumu = "Giriş değerleri yanlış";
                }

                ViewBag.SonucDurumu = sonucDurumu;

                return PartialView("_SonucPartialView", _exampleModel);
            }
            else
            {
                ViewBag.Hata = "Geçersiz giriş!";
                return PartialView("_SonucPartialView"); // Hatalı giriş durumu için kısmi görünümü direkt dön
            }
        }





    }
}
