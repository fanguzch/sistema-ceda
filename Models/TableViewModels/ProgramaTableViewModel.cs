using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CEDASistema.Models
{
    public class ProgramaTableViewModel
    {
        public int? idPrograma { get; set; }
        public string namePrograma { get; set; }
        public int? idEstadoProg { get; set; }
        public string objetivosPrograma { get; set; }
    }
}