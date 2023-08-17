using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UygulamaHavuzu_1._0.Models
{
    public class YapmaListesiReporsitory
    {
        private static List<YapmaListesi> _YapmaListesi=new List<YapmaListesi>();


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
                throw new Exception("Yapılacak bulunmamaktadır.");
            }

            hasList.Do=updateDo.Do;

            var index = _YapmaListesi.FindIndex(x => x.Id == updateDo.Id);

            _YapmaListesi[index] = hasList;

        }

    }
}
