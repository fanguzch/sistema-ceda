using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CEDASistema.Models.ViewModels

{
    public class CursoViewModel
    {
        [Required]
        [Display(Name = "Nombre Curso")]
        public string nombreCurso { get; set; }
        [Required]
        [Display(Name = "ID Modalidad")]
        public int? IDmodalidad { get; set; }
        [Required]
        [Display(Name = "ID Sede")]
        public int? IDSede {  get; set; }
        [Required]
        [Display(Name = "ID Estado")]
        public int? IDEstado { get; set; }
        [Required]
        [Display(Name = "ID Programa")]
        public int? IDProg {  get; set; }

    }
}