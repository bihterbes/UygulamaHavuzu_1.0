using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UygulamaHavuzu_1._0.Controllers
{
    public class HavaDurumuController : Controller
    {
        public IActionResult HavaDurumuApp()
        {
            return View();
        }
    }
}
