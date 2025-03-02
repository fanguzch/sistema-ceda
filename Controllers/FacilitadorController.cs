using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CEDASistema.Models;
using CEDASistema.Models.TableViewModels;
using CEDASistema.Models.ViewModels;

namespace CEDASistema.Controllers
{
    public class FacilitadorController : Controller
    {
        // GET: Facilitador
        public ActionResult Index()
        {
            List<FacilitadorTableViewModel> lst = null; 
            using (BDPIDEntities db = new BDPIDEntities())
            {
                lst = (from d in db.Facilitadors
                      where d.idTipo == 1
                      orderby d.primerApellido
                      select new FacilitadorTableViewModel
                      {
                          id = d.idFacilitador,
                          cedula = d.cedulaFacilitador,
                          nombre = d.nombreFacilitador,
                          Papellido = d.primerApellido,
                          Sapellido = d.segundoApellido,
                          mail = d.correoElectronico
                      }).ToList();
            }

            return View(lst);
        }

        [HttpGet]
        public ActionResult AddFas()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddFas(FacilitadorViewModel model)
        {
            if(!ModelState.IsValid) 
            {
                return View(model);
            }

            using (var db= new BDPIDEntities())
            {
                Facilitador oFacilitador = new Facilitador();
                oFacilitador.nombreFacilitador = model.nombreFas;
                oFacilitador.primerApellido = model.primerApe;
                oFacilitador.segundoApellido = model.segundoApe;
                oFacilitador.cedulaFacilitador = (long)model.idFas;
                oFacilitador.correoElectronico = model.mailFas;
                oFacilitador.telefono = (long)model.telFas;
                oFacilitador.idTipo = model.tipoFas;
                oFacilitador.contraseñaFacilitador = model.password;

                db.Facilitadors.Add(oFacilitador);
                db.SaveChanges();
            }

            return Redirect(Url.Content("~/Facilitador/"));

        }


    }
}