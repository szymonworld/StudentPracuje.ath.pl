using AutoMapper;
using Pracuj.ath.bielsko.pl.ViewModels;
using Pracuj.Models;
using Pracuj.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pracuj.ath.bielsko.pl.Controllers
{
    public class AddJobOffertController : Controller
    {
        private IRepositoryService<JobCategories> _jobCategories;
        private IRepositoryService<ContractTypes> _contractTypes;
        private IRepositoryService<ExperienceTypes> _experienceTypes;
        private IRepositoryService<LvlOfEmployment> _lvlOfEmployment;
        private IRepositoryService<PostDuration> _postDuration;
        private IRepositoryService<Job> _job;

        public AddJobOffertController(IRepositoryService<JobCategories> jobCategories, IRepositoryService<ContractTypes> contractTypes,
                                      IRepositoryService<ExperienceTypes> experienceTypes, IRepositoryService<LvlOfEmployment> lvlOfEmployment,
                                      IRepositoryService<PostDuration> postDuration, IRepositoryService<Job> job)
        {
            _jobCategories = jobCategories;
            _contractTypes = contractTypes;
            _experienceTypes = experienceTypes;
            _lvlOfEmployment = lvlOfEmployment;
            _postDuration = postDuration;
            _job = job;
        }

        public ActionResult AddJobOffert()
        {
            var model = new AddJobOffertViewModel();
            PopulateSelectList(model);

            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult AddJobOffert(AddJobOffertViewModel model)
        {
            if (ModelState.IsValid)
            {
                PopulateSelectList(model);
                Job newJob = Mapper.Map<AddJobOffertViewModel, Job>(model);
                newJob.Description = model.JobDescription;
                newJob.ContractType = _contractTypes.FindBy(x => x.Id == model.ContractTypeId).Single().Name;
                newJob.Experience = _experienceTypes.FindBy(x => x.Id == model.ExperienceId).Single().Name;
                newJob.JobCategory = _jobCategories.FindBy(x => x.Id == model.JobCategoryId).Single().Name;

                _job.Add(newJob);
                _job.Save();

                return RedirectToAction("AddJobConfirmation");
                return View(model);
            }
            else
            {
                return AddJobOffert();
            }
        }

        private void PopulateSelectList(AddJobOffertViewModel model)
        {
            List<string> JobCategories = _jobCategories.GetAll().Select(x => x.Name).ToList();
            List<SelectListItem> jobcategoryitem = new List<SelectListItem>();

            for (int i = 0; i < JobCategories.Count(); i++)
            {
                jobcategoryitem.Add(new SelectListItem { Text = JobCategories[i], Value = $"{i + 1}" });
            }

            model.JobCategory = new SelectList(jobcategoryitem, "Value", "Text");

            List<string> ContractType = _contractTypes.GetAll().Select(x => x.Name).ToList();
            List<SelectListItem> contractTypesItems = new List<SelectListItem>();

            for (int i = 0; i < ContractType.Count(); i++)
            {
                contractTypesItems.Add(new SelectListItem { Text = ContractType[i], Value = $"{i + 1}" });
            }

            model.ContractType = new SelectList(contractTypesItems, "Value", "Text");


            List<string> ExperienceType = _experienceTypes.GetAll().Select(x => x.Name).ToList();
            List<SelectListItem> experienceTypeItems = new List<SelectListItem>();

            for (int i = 0; i < ExperienceType.Count(); i++)
            {
                experienceTypeItems.Add(new SelectListItem { Text = ExperienceType[i], Value = $"{i + 1}" });
            }

            model.Experience = new SelectList(experienceTypeItems, "Value", "Text");

            List<string> LvlOfEmployment = _experienceTypes.GetAll().Select(x => x.Name).ToList();
            List<SelectListItem> LvlOfEmploymentItems = new List<SelectListItem>();

            for (int i = 0; i < LvlOfEmployment.Count(); i++)
            {
                LvlOfEmploymentItems.Add(new SelectListItem { Text = LvlOfEmployment[i], Value = $"{i + 1}" });
            }

            model.LvlOfEmployment = new SelectList(LvlOfEmploymentItems, "Value", "Text");

            List<string> PostDuration = _postDuration.GetAll().Select(x => x.Name).ToList();
            List<SelectListItem> PostDurationItems = new List<SelectListItem>();

            for (int i = 0; i < PostDuration.Count(); i++)
            {
                PostDurationItems.Add(new SelectListItem { Text = PostDuration[i], Value = $"{i + 1}" });
            }

            model.PostDuration = new SelectList(PostDurationItems, "Value", "Text");
        }

        public ActionResult AddJobConfirmation()
        {
            return View();
        }

    }
}