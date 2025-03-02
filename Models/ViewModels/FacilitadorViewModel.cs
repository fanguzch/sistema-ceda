using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CEDASistema.Models.ViewModels
{
    public class FacilitadorViewModel
    {
        [Required]
        [Display(Name ="Nombre")]
        public string nombreFas { get; set; }
        [Required]
        [Display(Name = "Primer Apellido")]
        public string primerApe { get; set; }
        [Required]
        [Display(Name = "Segundo Apellido")]
        public string segundoApe { get; set; }
        [Required]
        [Display(Name = "Número de Cédula")]
        public long? idFas {  get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Correo Electrónico")]
        public string mailFas { get; set; }
        [Required]
        [Display(Name = "Télefono")]
        public long? telFas {  get; set; }
        [Required]
        [Display(Name = "Tipo de Usuario")]
        public int? tipoFas {  get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string password {  get; set; }
        [Display(Name = "Confirmar Contraseña")]
        [DataType(DataType.Password)]
        [Compare("password",ErrorMessage = "La contraseña ingresada no coincide con la ingresada anteriormente")]
        public string confirmPass {  get; set; }


    }
}