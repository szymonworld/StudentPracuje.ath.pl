using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pracuj.ath.bielsko.pl.Controllers
{
    public class EditorController : Controller
    {
        // GET: Editor
        public ActionResult Editor()
        {
            ViewBag.Data = "<ol><li><h2><em><s><cite> lokiec pieta niema klienta </cite></s></em></h2></li></ol>";
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Editor(string text)
        {
            return View(text);
        }
    }
}