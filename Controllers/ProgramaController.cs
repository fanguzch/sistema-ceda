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
    public class ProgramaController : Controller
    {
        // GET: Programa
        public ActionResult Index()
        {
            List<CEDASistema.Models.ProgramaTableViewModel> lst = null;
            using (BDPIDEntities db = new BDPIDEntities())
            {
                lst = (List<ProgramaTableViewModel>)(from d in db.Programas
                      orderby d.idPrograma
                      select new ProgramaTableViewModel
                      {
                          idPrograma = d.idPrograma,
                          namePrograma = d.nombrePrograma,
                          idEstadoProg = d.idEstadoCursoPrograma,
                          objetivosPrograma = d.objetivosPrograma
                      }).ToList();
            }


             return View(lst);
        }

        [HttpGet]
        public ActionResult AddProg()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProg(ProgramaViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using(var db = new BDPIDEntities())
            {
                Programa oProg = new Programa();
                oProg.nombrePrograma = model.nombreProg;
                oProg.idEstadoCursoPrograma = model.IDestadoProg;
                oProg.objetivosPrograma = model.objProgr;

                db.Programas.Add(oProg);

                db.SaveChanges();
            }

            return Redirect(Url.Content("~/Programa/"));

        }



    }
}