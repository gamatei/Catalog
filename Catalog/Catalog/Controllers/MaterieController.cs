using Catalog.BusinessLogic;
using Catalog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catalog.Controllers
{
    public class MaterieController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var listaMaterii = new MaterieBusiness().GetMaterii();
            return View(listaMaterii);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Create(MaterieModel materieModel)
        {
            if (ModelState.IsValid)
            {
                new MaterieBusiness().Insert(materieModel);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Materie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Materie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Materie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Materie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
