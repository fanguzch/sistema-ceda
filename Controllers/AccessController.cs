using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
            return View();
        }

        public ActionResult Enter(int user, string password)
        {
            if (Regex.IsMatch(user.ToString(), "^[a-z]+$", RegexOptions.IgnoreCase))
            {
                return Content("Favor ingrese su identificador numérico en el campo de usuario");
            }

            try
            {
                
                using (BDPIDEntities db= new BDPIDEntities ())
                {
                    var lst = from d in db.Facilitadors
                              where d.cedulaFacilitador == user && d.contraseñaFacilitador == password
                              select d;

                    if (lst.Count()>0)
                    {
                        Facilitador oUser = lst.First();
                        Session["User"] = oUser;
                        return Content("1");
                    }
                    else
                    {
                        return Content("USUARIO INVÁLIDO favor intente nuevamente");
                    }

                }
                    

            }catch (Exception ex)
            {
                return Content( "Ocurrió un error :( " + ex.Message);
            }

        }


    }
}