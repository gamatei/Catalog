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
        // GET: Materie
        public ActionResult Index()
        {

            return View();
        }

        // GET: Materie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Materie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Materie/Create
        [HttpPost]
        public ActionResult Create(MaterieModel collection)
        {
            try
            {
                // TODO: Add insert logic here
                // -> din controller trimiti modelul la business -=> transofrmi modelul in entitate -> trimiti entitadea din business in DAL -> salvezi in baza de date

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
