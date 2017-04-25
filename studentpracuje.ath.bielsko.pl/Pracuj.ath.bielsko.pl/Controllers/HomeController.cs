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
        [HttpPost]
        public JsonResult Index(string Prefix)
        {
            var SelectedName = (from N in DefaultFieldOfStudy()
                           where N.Name.StartsWith(Prefix)
                           select new { N.Name });
            return Json(SelectedName, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public List<FieldOfStudy> DefaultFieldOfStudy()
        {
            List<FieldOfStudy> Def = new List<FieldOfStudy>()
            {
                new FieldOfStudy {Name="Szymon" },
                new FieldOfStudy {Name="Szymon" },
                new FieldOfStudy {Name="Sławek" },
                new FieldOfStudy {Name="Lolek" },
                new FieldOfStudy {Name="Piotr" },
                new FieldOfStudy {Name="Piotr" },
                new FieldOfStudy {Name="Piotr" },
                new FieldOfStudy {Name="Piotr" },
                new FieldOfStudy {Name="Piotr" },
                new FieldOfStudy {Name="Piotr" },
        };
            return Def;
        }

    }
}