using PagedList;
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
        public ActionResult JobOffers(int? page)
        {
            const int pageSize = 3;
            int pageIndex = (page ?? 1);

            List<OffertViewModel> Offerts = new List<OffertViewModel>();
            Offerts.Add(new OffertViewModel { Id = 1, Company = "Apple", Description = "Podawanie kawy", Location = "Dubaj", PostedDate = DateTime.Now.Date, Title = "Swift Senior Analyst Programmer", ContractType="Praca tymczasowa",  Img = Url.Content("~/Content/themes/images/apple.png"), JobCategory="Programista" });
            Offerts.Add(new OffertViewModel { Id = 2, Company = "Microsoft", Description = "Podawanie kawy", Location = "California", PostedDate = DateTime.Now.Date, Title = "C# Junior MVC Developer", ContractType = "Staż", Img = Url.Content("~/Content/themes/images/ms.png"), JobCategory = "Programista" });
            Offerts.Add(new OffertViewModel { Id = 3, Company = "Apple", Description = "Podawanie kawy", Location = "Dubaj", PostedDate = DateTime.Now.Date, Title = "Podawanie kawy mrożonej", ContractType = "Praca stała", Img = Url.Content("~/Content/themes/images/apple.png"), JobCategory = "Barman" });
            Offerts.Add(new OffertViewModel { Id = 4, Company = "Apple", Description = "Podawanie kawy", Location = "Dubaj", PostedDate = DateTime.Now.Date, Title = "Swift Senior Analyst Programmer", ContractType = "Praca tymczasowa", Img = Url.Content("~/Content/themes/images/apple.png"), JobCategory = "Programista" });
            Offerts.Add(new OffertViewModel { Id = 5, Company = "Apple", Description = "Podawanie kawy", Location = "Dubaj", PostedDate = DateTime.Now.Date, Title = "Swift Senior Analyst Programmer", ContractType = "Praca tymczasowa", Img = Url.Content("~/Content/themes/images/apple.png"), JobCategory = "Programista" });
            Offerts.Add(new OffertViewModel { Id = 6, Company = "Apple", Description = "Podawanie kawy", Location = "Dubaj", PostedDate = DateTime.Now.Date, Title = "Swift Senior Analyst Programmer", ContractType = "Praca tymczasowa", Img = Url.Content("~/Content/themes/images/apple.png"), JobCategory = "Programista" });
            Offerts.Add(new OffertViewModel { Id = 7, Company = "Apple", Description = "Podawanie kawy", Location = "Dubaj", PostedDate = DateTime.Now.Date, Title = "Swift Senior Analyst Programmer", ContractType = "Praca tymczasowa", Img = Url.Content("~/Content/themes/images/apple.png"), JobCategory = "Programista" });
            Offerts.Add(new OffertViewModel { Id = 8, Company = "Apple", Description = "Podawanie kawy", Location = "Dubaj", PostedDate = DateTime.Now.Date, Title = "Swift Senior Analyst Programmer", ContractType = "Praca tymczasowa", Img = Url.Content("~/Content/themes/images/apple.png"), JobCategory = "Programista" });

            IPagedList<OffertViewModel> IOfferts = Offerts.ToPagedList(pageIndex, pageSize);

            //ViewBag.Offerts = Offerts;
            return View(IOfferts);
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