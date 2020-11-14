using Catalog.BusinessLogic;
using Catalog.Model;
using System.Web.Mvc;

namespace Catalog.Controllers
{
    public class AbsentaController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var listaAbsente = new AbsentaBusiness().GetAbsente();
            var loggedUser = User.Identity.Name;

            return View(listaAbsente);
        }

        [HttpGet]
        public ActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult Create(AbsentaModel absentaModel)
        {
            if (ModelState.IsValid)
            {
                new AbsentaBusiness().Insert(absentaModel);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            new AbsentaBusiness().Delete(id);

            return View("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = new AbsentaBusiness().Get(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(int id, AbsentaModel absenta)
        {
            if (ModelState.IsValid)
            {
                new AbsentaBusiness().Update(absenta);
            }
            return View();
        }
    }
}
