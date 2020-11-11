using Catalog.BusinessLogic;
using Catalog.Model;
using System;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Catalog.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login(string ReturnUrl = "")
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel loginModel, string ReturnUrl = "" )
        {
            if (ModelState.IsValid)
            {
                var user = new UtilizatorBusiness().ValidateUser(loginModel.Username, loginModel.Parola);

                if (user != null)
                {
                    //FormsAuthentication.SetAuthCookie(userModel.UserName, false);
                    var authTicket = new FormsAuthenticationTicket(1, loginModel.Username, DateTime.Now, DateTime.Now.AddMinutes(20), loginModel.RememberMe, user.Functie);
                    string encryptedTicket = FormsAuthentication.Encrypt(authTicket);

                    var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                    System.Web.HttpContext.Current.Response.Cookies.Add(authCookie);

                    return RedirectToAction("Index", "Utilizator");
                    //return RedirectToRoute(ReturnUrl);
                }
                ModelState.AddModelError("", "Invalid Username or Password");
            }
            return View();
        }
        
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}