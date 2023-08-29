using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UygulamaHavuzu_1._0.Models
{
    public class WeatherModels
    {
        public string Name { get; set; } // Şehir adı
        public double WindSpeed { get; set; } // Rüzgar hızı
        public int Humidity { get; set; } // Nem
        public double Temperature { get; set; } // Sıcaklık

    }
    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }
    public class Main
    {
        public double temp { get; set; }
       
        public int humidity { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
    }
    public class Root
    {
       
        public List<Weather> weather { get; set; }
    
        public Main main { get; set; }
  
       public Wind wind { get; set; }
    
  
        public string name { get; set; }
     
     }
}
