using Catalog.BusinessLogic;
using Catalog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catalog.Controllers
{
    public class MaterieClasaController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var listaMaterieClase = new MaterieClasaBusiness().GetMaterieClase();
            var loggedUser = User.Identity.Name;

            return View(listaMaterieClase);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(MaterieClasaModel materieClasaModel)
        {
            if (ModelState.IsValid)
            {
                new MaterieClasaBusiness().Insert(materieClasaModel);
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }


        [HttpPost]
        public ActionResult Edit(int id, MaterieClasaModel materieClasa)
        {
            if (ModelState.IsValid)
            {
                new MaterieClasaBusiness().Update(materieClasa);
            }
            return View();
        }


        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new MaterieClasaBusiness().Delete(id);

            return View("index");
        }

    }
}

