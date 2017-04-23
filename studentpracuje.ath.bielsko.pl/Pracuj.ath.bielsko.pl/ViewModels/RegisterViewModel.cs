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
        Student,
        [Display(Name = "Pracodawca")]
        Employer
    }


    public class RegisterViewModel
    {
        [Display(Name = "Login")]
        [Required(ErrorMessage = "Wprowadz login")]
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Login za krotki")]
        public string Login { get; set; }
        [Display(Name = "Hasło")]
        [Required(ErrorMessage = "Wprowadz Hasło")]
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Hasło za krotkie")]
        public string Password { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Wprowadz Email")]
        [EmailAddress(ErrorMessage = "Adres email jest nieprawidłowy")]
        public string Email { get; set; }
        [Display(Name = "Imie")]
        [Required(ErrorMessage = "Wprowadz swoje Imie")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Wprowadz swoje nazwisko")]
        public string Surname { get; set; }
        [Display(Name = "Data urodzenia")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Typ konta")]
        [Required(ErrorMessage = "Typ konta")]
        public AccountType AccountType { get; set; }
    }
}