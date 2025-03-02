using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CEDASistema.Models.TableViewModels
{
    public class FacilitadorTableViewModel
    {
        public int id { get; set; }
        public long cedula { get; set; }
        public string nombre { get; set; }
        public string Papellido { get; set; }
        public string Sapellido { get; set; }
        public string mail { get; set; }
        
    }
}