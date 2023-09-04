using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UygulamaHavuzu_1._0.Models;
using UygulamaHavuzu_1._0.ViewModel;

namespace UygulamaHavuzu_1._0.Mapping
{

    public class ViewModelMapping:Profile
    {

        public ViewModelMapping()
        {
            CreateMap<YapmaListesi, TodoViewModel>().ReverseMap();

        }
    }
}
