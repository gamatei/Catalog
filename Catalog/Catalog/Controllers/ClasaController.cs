using Catalog.BusinessLogic;
using Catalog.Model;
using System.Web.Mvc;

namespace Catalog.Controllers
{
    [Authorize(Roles = "Admin,Profesor")]
    public class ClasaController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var listaClase = new ClasaBusiness().GetClase();
            var loggedUser = User.Identity.Name;

            return View(listaClase);
        }

        [HttpGet]
        public ActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult Create(ClasaModel clasaModel)
        {
            if (ModelState.IsValid)
            {
                new ClasaBusiness().Insert(clasaModel);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            new ClasaBusiness().Delete(id);

            return View("index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = new ClasaBusiness().Get(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(int id, ClasaModel clasa)
        {
            if (ModelState.IsValid)
            {
                new ClasaBusiness().Update(clasa);
            }
            return View();
        }
    }
}
