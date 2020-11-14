using Catalog.BusinessLogic;
using Catalog.Model;
using System.Web.Mvc;

namespace Catalog.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UtilizatorController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var listaUtilizatori = new UtilizatorBusiness().GetUsers();
            var loggedUser = User.Identity.Name;

            return View(listaUtilizatori);
        }

        // Utilizator/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Role = "Admin";
            ViewBag.Functii = UtilizatorBusiness.GetFunctions("Admin");
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
        [HttpGet]
        public ActionResult Delete(int id)
        {
            new UtilizatorBusiness().Delete(id);

            return View("index");
        }

        //[HttpGet]
        //public ActionResult Delete()
        //{
        //    return View();
        //}

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