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
    public class CursoController : Controller
    {
        // GET: Curso
        public ActionResult Index()
        {
            List<CEDASistema.Models.TableViewModels.CursoTableViewModel> lst = null;
            using (BDPIDEntities db = new BDPIDEntities())
            {
                lst = (List<CursoTableViewModel>)(from d in db.Cursoes
                      orderby d.idCurso
                      select new CursoTableViewModel
                      {
                          idCurso = d.idCurso,
                          nameCurso = d.nombreCurso,
                          idModalidad = d.idModalidad,
                          idSede = d.idSede,
                          idEstado = d.idEstadoCursoPrograma,
                          idPrograma = d.idPrograma
                      }).ToList();

            }



            return View(lst);
        }


        [HttpGet]
        public ActionResult AddCurso()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddCurso(CursoViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            using (var db=new BDPIDEntities())
            {
                Curso oCurso = new Curso();

                oCurso.nombreCurso = model.nombreCurso;
                oCurso.idModalidad = model.IDmodalidad;
                oCurso.idSede = model.IDSede;
                oCurso.idEstadoCursoPrograma = model.IDEstado;
                oCurso.idPrograma = model.IDProg;

                db.Cursoes.Add(oCurso);
                db.SaveChanges();

            }

            return Redirect(Url.Content("~/Curso/"));


        }





    }
}