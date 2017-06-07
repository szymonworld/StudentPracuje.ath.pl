using Pracuj.Models;
using Pracuj.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pracuj.ath.bielsko.pl.Controllers
{
    public class JobController : Controller
    {
        private IRepositoryService<Job> _job;
        public JobController(IRepositoryService<Job> job)
        {
            _job = job;
        }
        [HttpPost]
        public ActionResult JobView(int id)
        {
            return View(_job.GetSingle(id));
        }

        public ActionResult JobManagement()
        {
            return View();
        }
    }
}