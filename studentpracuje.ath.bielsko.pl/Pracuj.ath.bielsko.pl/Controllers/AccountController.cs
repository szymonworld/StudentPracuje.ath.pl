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
using AutoMapper;
using Pracuj.ath.bielsko.pl.Utils;
using System.Security.Claims;
using Microsoft.AspNet.Identity;

namespace Pracuj.ath.bielsko.pl.Controllers
{
    public class AccountController : Controller
    {
        private IRepositoryService<Student> _students;
        private IRepositoryService<Employer> _employers;
        private IRepositoryService<User> _users;
        private IPasswordEncryptionService _encryption;

        public AccountController(IRepositoryService<Student> students, IRepositoryService<Employer> employers, IRepositoryService<User> users, IPasswordEncryptionService encryption)
        {
            _students = students;
            _employers = employers;
            _users = users;
            _encryption = encryption;
        }

        [HttpGet]
        public ActionResult RegisterConfirmation()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User newUser = Mapper.Map<RegisterViewModel, User>(model);
                UserValidation val = new UserValidation(newUser, _users);

                RegistrationMsg valMsg = val.Validate();

                if(valMsg == RegistrationMsg.OK)
                {
                    newUser.Password = _encryption.EncryptPassword(newUser.Password);
                    newUser.Verified = false;

                    if(model.AccountType == AccountType.Student)
                    {
                        Student newStudent = Mapper.Map<User, Student>(newUser);
                        newStudent.AlbumNumber = model.AlbumNumber;
                        _students.Add(newStudent);
                        _students.Save();
                    }
                    else
                    {
                        Employer newEmployer = Mapper.Map<User, Employer>(newUser);
                        _employers.Add(newEmployer);
                        _employers.Save();
                    }

                    return RedirectToAction("RegisterConfirmation");
                }
                else
                {
                    ViewBag.ValidationError = MessageTranslator.Translate(valMsg);
                }


            }

            return View();
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

                if (user != null && _encryption.VerifyPassword(model.Password, user.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Login, false);
                    return RedirectToAction("Index", "Home");
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

        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}