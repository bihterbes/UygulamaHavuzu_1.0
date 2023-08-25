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

            
          

        }
        public IActionResult ToDoApp()
        {
            var listeler = _YapmaListesiReporsitory.GetAll();
            return View(listeler);
        }

        public IActionResult Remove(int id)
        {
            _YapmaListesiReporsitory.Remove(id);
            return RedirectToAction("ToDoApp");
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Update(int id)
        {
            return View();
        }



    }
}
