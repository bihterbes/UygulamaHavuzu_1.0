using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UygulamaHavuzu_1._0.Models;
using UygulamaHavuzu_1._0.ViewModel;

namespace UygulamaHavuzu_1._0.Views.Shared.ViewComponents
{
    public class ListViewComponent:ViewComponent
    {

        private readonly AppDbContext _context;

        public ListViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int type=1)
        {
            var viewmodels = _context.Todo_tablo.Select(x => new ListComponentViewModel()
            {
                Id = x.Id,
                Do = x.Do,
                TamamlandiMi = x.TamamlandiMi

            }).ToList();


            if(type==1)
            {
                return View("Default", viewmodels);
            }
            else
            {
                return View("Form2", viewmodels);
            }
            

        }

    }
}
