using Catalog.BusinessLogic;
using Catalog.Model;
using System.Web.Mvc;

namespace Catalog.Controllers
{
    [Authorize(Roles = "Admin,Profesor")]
    public class ElevController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var listaUtilizatori = new ElevBusiness().GetElevi();
            var loggedUser = User.Identity.Name;

            return View(listaUtilizatori);
        }
                
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ElevModel elevModel)
        {
            if (ModelState.IsValid)
            {
                new ElevBusiness().Insert(elevModel);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            new ElevBusiness().Delete(id);

            return View("index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = new ElevBusiness().Get(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(int id, ElevModel elev)
        {
            if (ModelState.IsValid)
            {
                new ElevBusiness().Update(elev);
            }
            return View();
        }
    }
}
