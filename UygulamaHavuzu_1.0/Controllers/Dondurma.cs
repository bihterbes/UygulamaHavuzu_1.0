using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UygulamaHavuzu_1._0.Controllers
{
    public class Dondurma : Controller
    {
        public IActionResult kaymak()
        {
            return View();
        }
    }
}
