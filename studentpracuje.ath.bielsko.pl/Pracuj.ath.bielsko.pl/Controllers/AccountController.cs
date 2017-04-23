using Pracuj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BCrypt.Net;
using Pracuj.Services;
using Pracuj.ath.bielsko.pl.ViewModels;
using System.Web.Security;

namespace Pracuj.ath.bielsko.pl.Controllers
{
    public class AccountController : Controller
    {
        private IRepositoryService<Student> _students;
        private IRepositoryService<Employer> _employers;
        private IRepositoryService<User> _users;

        public AccountController(IRepositoryService<Student> students, IRepositoryService<Employer> employers, IRepositoryService<User> users)
        {
            _students = students;
            _employers = employers;
            _users = users;
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {

            }

            return View(model);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid && model.Login.Length > 3 && model.Password.Length > 6)
            {
                var user = _users.FindBy(x => x.Login == model.Login).ToList().FirstOrDefault();
                string myHash = BCrypt.Net.BCrypt.HashPassword(model.Password, BCrypt.Net.BCrypt.GenerateSalt());

                if(user != null && BCrypt.Net.BCrypt.Verify(user.Password, myHash))
                {
                    FormsAuthentication.SetAuthCookie(model.Login, true);
                    return Redirect(Request.UrlReferrer.ToString());
                }
                {
                    ViewBag.LoginError = "Login lub haslo jest nieprawidlowe!";
                }

            }
            else
            {
                ViewBag.LoginError = "Wystapil blad.";
            }

            return View();
        }
    }
}