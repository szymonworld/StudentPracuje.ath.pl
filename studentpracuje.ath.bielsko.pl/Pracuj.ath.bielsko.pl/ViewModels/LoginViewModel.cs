using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pracuj.ath.bielsko.pl.ViewModels
{
    [FluentValidation.Attributes.Validator(typeof(LoginValidation))]
    public class LoginViewModel
    {
        [Display(Name = "Login")]
        [DataType(DataType.Text)]
        public string Login { get; set; }
        [Display(Name = "Hasło")]
        [DataType(DataType.Text)]
        public string Password { get; set; }

    }
    public class LoginValidation : AbstractValidator<LoginViewModel>
    {
        public LoginValidation()
        {
            RuleFor(x => x.Login).NotNull().WithMessage("Wprowadz login").Length(2, 30).WithMessage("Login za krotki");
            RuleFor(x => x.Password).NotNull().WithMessage("Wprowadz Hasło").Length(6, 255).WithMessage("Hasło jest za krótkie");
        }
    }
}