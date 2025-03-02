using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CEDASistema.Models.TableViewModels
{
    public class CursoTableViewModel
    {
        public int idCurso {  get; set; }
        public string nameCurso { get; set; }
        public int? idModalidad {  get; set; }
        public int? idSede {  get; set; }
        public int? idEstado {  get; set; }
        public int? idPrograma {  get; set; }
    }
}