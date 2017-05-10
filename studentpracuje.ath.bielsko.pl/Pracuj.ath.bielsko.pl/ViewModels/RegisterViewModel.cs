using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pracuj.ath.bielsko.pl.ViewModels
{
    public enum AccountType
    {
        [Display(Name = "Student")]
        Student = 1,
        [Display(Name = "Pracodawca")]
        Employer = 2
    }

    [FluentValidation.Attributes.Validator(typeof(RegisterValidation))]
    public class RegisterViewModel
    {
        [Display(Name = "Login")]
        [DataType(DataType.Text)]
        public string Login { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Imie")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }
        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Typ konta")]
        [Range(1, 2, ErrorMessage = "Wybierz typ konta")]
        public AccountType AccountType { get; set; }
        [Display(Name = "Numer albumu")]
        public string AlbumNumber { get; set; }
    }
    public class RegisterValidation : AbstractValidator<RegisterViewModel>
    {
        public RegisterValidation()
        {
            RuleFor(x => x.Login).NotNull().WithMessage("Wprowadz login").Length(2, 30).WithMessage("Login za krotki");
            RuleFor(x => x.Password).NotNull().WithMessage("Wprowadz Hasło").Length(6, 255).WithMessage("Hasło jest za krótkie");
            RuleFor(x => x.Email).NotNull().WithMessage("Wprowadz adres email").Length(5, 255).WithMessage("Adres email za krótki").EmailAddress().WithMessage("Adres email jest nieprawidłowy");
            RuleFor(x => x.Name).NotNull().WithMessage("Wprowadz swoje imie");
            RuleFor(x => x.Surname).NotNull().WithMessage("Wprowadz swoje nazwisko");
            RuleFor(x => x.AccountType).NotNull().WithMessage("Typ konta");
            RuleFor(x => x.BirthDate).NotNull().WithMessage("Data urodzenia nie może być pusta");
            RuleFor(x => x.AlbumNumber).NotNull().When(n => n.AccountType == AccountType.Student);
        }
    }
}