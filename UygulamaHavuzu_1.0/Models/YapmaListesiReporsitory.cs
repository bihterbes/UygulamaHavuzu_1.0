using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UygulamaHavuzu_1._0.Models
{
    public class YapmaListesiReporsitory
    {
        private static List<YapmaListesi> _YapmaListesi=new List<YapmaListesi>()
        {
              new() { Id = 1, Do = "Bugün yapcak bişi var ama yok" },
              new() { Id = 2, Do = "Kedi sevmek" },
              new() { Id = 3, Do = "Saygınlık" }
        };
        //bu statik düzelt


        public List<YapmaListesi> GetAll() => _YapmaListesi;
        public void Add(YapmaListesi newYapmaListesi) => _YapmaListesi.Add(newYapmaListesi);
        
        public void Remove (int id)
        {
            var hasList = _YapmaListesi.FirstOrDefault(x=>x.Id ==id);
            if(hasList==null)
            {
                throw new Exception("Yapılacak bulunmamaktadır.");
            }

            _YapmaListesi.Remove(hasList);
        
        }

        public void Update(YapmaListesi updateDo)
        {
            var hasList = _YapmaListesi.FirstOrDefault(x => x.Id == updateDo.Id);
            if (hasList == null)
            {
                throw new Exception($"Bu id({updateDo.Id})'ye sahip yapılacak bulunmamaktadır.");
            }

            hasList.Do=updateDo.Do;
           // hasList.Name = updateDo.Name;

            var index = _YapmaListesi.FindIndex(x => x.Id == updateDo.Id);

            _YapmaListesi[index] = hasList;

        }

    }
}
