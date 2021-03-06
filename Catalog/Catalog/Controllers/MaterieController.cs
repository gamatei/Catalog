﻿using Catalog.BusinessLogic;
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
            var loggedUser = User.Identity.Name;

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

        
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Edit(int id, MaterieModel materie)
        {
            if (ModelState.IsValid)
            {
                new MaterieBusiness().Update(materie);
            }
            return View();
        }
                
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new MaterieBusiness().Delete(id);

            return View();
        }
                
    }
}
