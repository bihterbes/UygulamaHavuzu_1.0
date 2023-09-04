using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UygulamaHavuzu_1._0.ViewModel
{
    public class TodoViewModel
    {
        public int Id { get; set; }
        public string Do { get; set; }

        public bool? IsCompleted { get; set; }

        public bool TamamlandiMi { get; set; }
    }
}
