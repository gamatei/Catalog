using Catalog.BusinessLogic;
using Catalog.Model;
using System.Web.Mvc;

namespace Catalog.Controllers
{
    public class NotaController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var listaNote = new NotaBusiness().GetNotes();
            var loggedUser = User.Identity.Name;

            return View(listaNote);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(NotaModel notaModel)
        {
            if (ModelState.IsValid)
            {
                new NotaBusiness().Insert(notaModel);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            new NotaBusiness().Delete(id);

            return View("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = new NotaBusiness().Get(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(int id, NotaModel nota)
        {
            if (ModelState.IsValid)
            {
                new NotaBusiness().Update(nota);
            }
            return View();
        }
    }
}
