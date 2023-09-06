using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UygulamaHavuzu_1._0.ViewModel
{
    public class HavaPartialViewModel
    {
        
        public string City { get; set; }
        public string Description { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double WindSpeed { get; set; }
        public string WeatherIcon { get; set; }
        public DateTime LastUpdated { get; set; }



    }
    
}
