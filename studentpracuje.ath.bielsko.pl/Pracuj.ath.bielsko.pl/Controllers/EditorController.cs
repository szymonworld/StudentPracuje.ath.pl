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
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Editor(string text)
        {
            return View();
        }
    }
}