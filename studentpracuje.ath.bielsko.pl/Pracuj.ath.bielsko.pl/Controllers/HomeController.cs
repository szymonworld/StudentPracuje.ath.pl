using Pracuj.ath.bielsko.pl.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pracuj.ath.bielsko.pl.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult JobOffers()
        {
            List<OffertViewModel> Offerts = new List<OffertViewModel>();
            Offerts.Add(new OffertViewModel { Id = 1, Company = "Microsoft", Description = "Podawanie kawy", Location = "Dubaj", PostedDate = DateTime.Now, Title = "Pomocnik do kawy" });
            Offerts.Add(new OffertViewModel { Id = 2, Company = "Microsoft", Description = "Podawanie kawy", Location = "Dubaj", PostedDate = DateTime.Now, Title = "Pomocnik do kawy" });
            Offerts.Add(new OffertViewModel { Id = 3, Company = "Microsoft", Description = "Podawanie kawy", Location = "Dubaj", PostedDate = DateTime.Now, Title = "Pomocnik do kawy" });
            Offerts.Add(new OffertViewModel { Id = 4, Company = "Microsoft", Description = "Podawanie kawy", Location = "Dubaj", PostedDate = DateTime.Now, Title = "Pomocnik do kawy" });
            Offerts.Add(new OffertViewModel { Id = 5, Company = "Microsoft", Description = "Podawanie kawy", Location = "Dubaj", PostedDate = DateTime.Now, Title = "Pomocnik do kawy" });
            Offerts.Add(new OffertViewModel { Id = 6, Company = "Microsoft", Description = "Podawanie kawy", Location = "Dubaj", PostedDate = DateTime.Now, Title = "Pomocnik do kawy" });

            ViewBag.Offerts = Offerts;
            return View();
        }
        [HttpPost]
        public JsonResult Index(string Prefix)
        {
            var SelectedName = (from N in DefaultFieldOfStudy()
                           where N.Name.StartsWith(Prefix)
                           select new { N.Name });
            return Json(SelectedName, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public List<FieldOfStudyViewModel> DefaultFieldOfStudy()
        {
            List<FieldOfStudyViewModel> Def = new List<FieldOfStudyViewModel>()
            {
                new FieldOfStudyViewModel {Name="Szymon" },
                new FieldOfStudyViewModel {Name="Szymon" },
                new FieldOfStudyViewModel {Name="Sławek" },
                new FieldOfStudyViewModel {Name="Lolek" },
                new FieldOfStudyViewModel {Name="Piotr" },
                new FieldOfStudyViewModel {Name="Piotr" },
                new FieldOfStudyViewModel {Name="Piotr" },
                new FieldOfStudyViewModel {Name="Piotr" },
                new FieldOfStudyViewModel {Name="Piotr" },
                new FieldOfStudyViewModel {Name="Piotr" },
        };
            return Def;
        }

    }
}