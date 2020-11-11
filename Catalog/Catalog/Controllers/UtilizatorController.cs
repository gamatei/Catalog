using Catalog.BusinessLogic;
using Catalog.Model;
using System.Web.Mvc;
using System.Security.Principal;
using System.Web.Security;

namespace Catalog.Controllers
{
    [Authorize(Roles = "Admin,Profesor,Elev")]
    public class UtilizatorController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var listaUtilizatori = new UtilizatorBusiness().GetUsers();
            var loggedUser = User.Identity.Name;
            // daca userul logat e admin vede tot, daca e profesor vede doar elevii si parintii
            // .Where(x = > x.FunctieId = 3 || 4)

            return View(listaUtilizatori);
        }

        // Utilizator/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Role = "Admin";
            ViewBag.Functii = UtilizatorBusiness.GetFunctions("Profesor");
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
        public ActionResult Edit(int id)
        {
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