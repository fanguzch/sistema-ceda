using System;
using System.Web;
using System.Web.Mvc;
using CEDASistema.Models;

namespace CEDASistema.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
            // Solo redirige si el usuario no está autenticado
            if (Session["User"] == null)
            {
                return RedirectToAction("Enter", "Access");
            }

            // Si ya hay un usuario autenticado, no redirige
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Enter()
        {
            // Simulación de login sin acceder a la base de datos
            try
            {
                // Crear un usuario simulado
                Facilitador simulatedUser = new Facilitador
                {
                    cedulaFacilitador = 12345678, // ID simulado
                    contraseñaFacilitador = "simulatedPassword",
                    nombreFacilitador = "Usuario Simulado"
                };

                // Establecer el usuario en la sesión para simular que ha iniciado sesión
                Session["User"] = simulatedUser;
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                return Content("Ocurrió un error :( " + ex.Message);
            }
        }
    }
}
