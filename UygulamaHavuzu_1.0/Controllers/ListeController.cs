using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UygulamaHavuzu_1._0.Models;

namespace UygulamaHavuzu_1._0.Controllers
{
    public class ListeController : Controller
    {
        private readonly YapmaListesiReporsitory _YapmaListesiReporsitory;

        public ListeController()
        {
            _YapmaListesiReporsitory =new YapmaListesiReporsitory();

            if (!_YapmaListesiReporsitory.GetAll().Any())
            {
                _YapmaListesiReporsitory.Add(new() { Id = 1, Do = "Bugün yapcak bişi var ama yok" });
                _YapmaListesiReporsitory.Add(new() { Id = 2, Do = "Kedi sevmek" });
                _YapmaListesiReporsitory.Add(new() { Id = 3, Do = "Saygınlık" });

            }
          

        }
        public IActionResult ToDoApp()
        {
            var listeler = _YapmaListesiReporsitory.GetAll();
            return View(listeler);
        }
        
    }
}
