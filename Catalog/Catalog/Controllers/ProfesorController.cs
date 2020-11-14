using Catalog.BusinessLogic;
using Catalog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catalog.Controllers
{
    public class ProfesorController : Controller
    {
        [Authorize(Roles = "Admin,Profesor")]
        [HttpGet]
        public ActionResult Index()
        {
            var listaProfesori = new ProfesorBusiness().GetProfessors();
            var loggedUser = User.Identity.Name;

            return View(listaProfesori);
        }

        [Authorize(Roles = "Admin")]
        // Profesor/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Role = "Profesor";
            ViewBag.Functii = ProfesorBusiness.GetFunctions("Profesor");
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Create(ProfesorModel profesorModel)
        {
            if (ModelState.IsValid)
            {
                new ProfesorBusiness().Insert(profesorModel);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new ProfesorBusiness().Delete(id);

            return View();
        }

        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = new ProfesorBusiness().Get(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(int id, ProfesorModel profesor)
        {
            if (ModelState.IsValid)
            {
                new ProfesorBusiness().Update(profesor);
            }
            return View();
        }
    }
}
