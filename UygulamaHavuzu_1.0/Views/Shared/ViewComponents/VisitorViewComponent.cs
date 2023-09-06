using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UygulamaHavuzu_1._0.Views.Shared.ViewComponents
{
    public class VisitorViewComponent:ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }


    }
}
