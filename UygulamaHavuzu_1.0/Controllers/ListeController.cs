using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UygulamaHavuzu_1._0.Models;
using UygulamaHavuzu_1._0.ViewModel;

namespace UygulamaHavuzu_1._0.Controllers
{
    public class ListeController : Controller
    {
        private AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly YapmaListesiReporsitory _YapmaListesiReporsitory;

        public ListeController(AppDbContext context, IMapper mapper)
        {
            _YapmaListesiReporsitory = new YapmaListesiReporsitory();

            _context = context;
            _mapper = mapper;
        }
        public IActionResult ToDoApp()


        {
            var listeler = _context.Todo_tablo.ToList();




           
            return View(_mapper.Map<List<TodoViewModel>>(listeler));



        }

        public IActionResult Remove(int id)
        {
            
	
            var liste = _context.Todo_tablo.Find(id);
            _context.Todo_tablo.Remove(liste);


            _context.SaveChanges();

            return RedirectToAction("ToDoApp");
        }
       
     

        [HttpPost]
        public IActionResult Add(string Do, bool TamamlandiMi)
        {
          
           
            YapmaListesi newListe = new YapmaListesi() { Do = Do, TamamlandiMi=TamamlandiMi };
            _context.Todo_tablo.Add(newListe);
            _context.SaveChanges();

            return Ok(newListe);

        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var list = _context.Todo_tablo.Find(id);
            return View(list);
        }

        [HttpPost]
        public IActionResult Update(YapmaListesi updateListe)
        {
            var existingListe = _context.Todo_tablo.Find(updateListe.Id);

            if (existingListe != null)
            {
                // Yeni bilgileri mevcut öğeye kopyalayın
                
                existingListe.TamamlandiMi = updateListe.TamamlandiMi;

                _context.Todo_tablo.Update(existingListe);

                _context.SaveChanges();
            }

            // _context.Todo_tablo.Update(updateListe);
            //_context.SaveChanges();




            return Ok(existingListe);
        }

        public IActionResult DenemeToDo()
        {
            return View();
        }
    }


}
