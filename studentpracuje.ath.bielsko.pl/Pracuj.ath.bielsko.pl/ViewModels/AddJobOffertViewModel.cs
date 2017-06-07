using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pracuj.ath.bielsko.pl.ViewModels
{
    [FluentValidation.Attributes.Validator(typeof(AddJobOffertValidation))]
    public class AddJobOffertViewModel
    {

        [Display(Name = "Stanowisko lub tytuł oferty")]
        public string Title { get; set; }
        public int JobCategoryId { get; set; }
        [Display(Name = "Branża")]
        public SelectList JobCategory { get; set; }
        public int ContractTypeId { get; set; }
        [Display(Name = "Forma zatrudnienia")]
        public SelectList ContractType { get; set; }
        [Display(Name = "Opis")]
        [AllowHtml]
        public string JobDescription { get; set; }
        [Display(Name = "Wynagrodzenie")]
        public string Salary { get; set; }
        [Display(Name = "Nazwa firmy")]
        public string CompanyName { get; set; }
        [Display(Name = "Strona firmy (opcjonalne)")]
        public string CompanyWebsite { get; set; }
        [Display(Name = "Logo firmy")]
        public HttpPostedFileBase Logo { get; set; }
        [Display(Name = "Region")]
        public string Region { get; set; }
        [Display(Name = "Miasto")]
        public string City { get; set; }
        [Display(Name = "Ulica")]
        public string Street { get; set; }
        [Display(Name = "Kraj")]
        public string Country { get; set; }
        public int ExperienceId { get; set; }
        [Display(Name = "Wymagane doświadczenie")]
        public SelectList Experience { get; set; }
        public int PostDurationId { get; set; }
        [Display(Name = "Czas trwania ogłoszenia")]
        public SelectList PostDuration { get; set; }
        public int LvlOfEmploymentId { get; set; }
        [Display(Name = "Wielkość zatrudnienia w firmie (opcjonalne)")]
        public SelectList LvlOfEmployment { get; set; }
    }
    public class AddJobOffertValidation : AbstractValidator<AddJobOffertViewModel>
    {
        public AddJobOffertValidation()
        {
            RuleFor(x => x.Title).NotNull().WithMessage("Wprowadz Tytuł").Length(3, 50).WithMessage("Tytuł za krótki");
            // RuleFor(x => x.JobCategoryId).NotNull().WithMessage("Wybierz branże");
            // RuleFor(x => x.ContractTypeId).NotNull().WithMessage("Wybierz typ zatrudnienia");
            // RuleFor(x => x.JobDescription).NotNull().WithMessage("Wprowadz opis");
            RuleFor(x => x.Salary).NotNull().WithMessage("Wprowadz wynagrodzenie");
            RuleFor(x => x.Region).NotNull().WithMessage("Wprowadz region").Length(3, 50).WithMessage("Nazwa regionu za krótki");
            RuleFor(x => x.City).NotNull().WithMessage("Wprowadz miasto").Length(3, 50).WithMessage("Nazwa miasta za krótki");
            RuleFor(x => x.Street).NotNull().WithMessage("Wprowadz ulice").Length(3, 150).WithMessage("Nazwa ulicy za krótki");
            RuleFor(x => x.Country).NotNull().WithMessage("Wprowadz kraj").Length(3, 50).WithMessage("Nazwa kraju za krótki");
            // RuleFor(x => x.PostDurationId).NotNull().WithMessage("Wprowadz czas trwania ogłoszenia");
        }
    }
}