using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pracuj.ath.bielsko.pl.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "Login")]
        [Required(ErrorMessage = "Wprowadz login")]
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Login za krotki")]
        public string Login { get; set; }
        [Display(Name = "Haslo")]
        [Required(ErrorMessage = "Wprowadz hasło")]
        [DataType(DataType.Text)]
        [StringLength(255, MinimumLength = 6, ErrorMessage = "Haslo za krotkie")]
        public string Password { get; set; }

    }
}