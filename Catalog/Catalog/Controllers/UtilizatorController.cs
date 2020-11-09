using Catalog.BusinessLogic;
using Catalog.Model;
using System.Linq;
using System.Web.Mvc;

namespace Catalog.Controllers
{
    public class UtilizatorController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            // tu ai user id-ul
            // tu ai role
            var listaUtilizatori = new UtilizatorBusiness().GetUsers().Where(x=>x.IDFunctie > 3);

            return View(listaUtilizatori);
        }

        // Utilizator/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UtilizatorModel utilizatorModel)
        {
            if (ModelState.IsValid)
            {
                new UtilizatorBusiness().Insert(utilizatorModel);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new UtilizatorBusiness().Delete(id);

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id) {
            var model = new UtilizatorBusiness().Get(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(int id, UtilizatorModel utilizator)
        {
            if (ModelState.IsValid)
            {
                new UtilizatorBusiness().Update(utilizator);
            }
            return View();
        }
    }
}