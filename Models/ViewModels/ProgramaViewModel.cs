using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CEDASistema.Models.ViewModels
{
    public class ProgramaViewModel
    {
        [Required]
        [Display(Name = "Nombre Programa")]
        public string nombreProg { get;set; }
        [Required]
        [Display(Name = "ID Estado de Programa")]
        public int? IDestadoProg { get; set; }
        [Required]
        [Display(Name = "Objetivos del Programa")]
        public string objProgr { get; set; }

    }
}