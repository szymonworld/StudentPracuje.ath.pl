using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pracuj.ath.bielsko.pl.Utils
{
    public static class MessageTranslator
    {
        public static string Translate(RegistrationMsg msg)
        {
            string message = "";

            switch (msg)
            {
                case RegistrationMsg.OK:
                    break;
                case RegistrationMsg.NULL:
                    message = "Nieznany błąd";
                    break;
                case RegistrationMsg.PASSWORD_TOO_SHORT:
                    message = "Hasło zbyt krótkie";
                    break;
                case RegistrationMsg.LOGIN_TOO_SHORT:
                    message = "Login zbyt krótki";
                    break;
                case RegistrationMsg.INVALID_EMAIL:
                    message = "Podany adres email jest niepoprawny";
                    break;
                case RegistrationMsg.LOGIN_ALREADY_EXIST:
                    message = "Login jest zajęty";
                    break;
                case RegistrationMsg.AT_LEAST_ONE_UPPERCASE:
                    message = "Hasło musi zawierać co najmniej jedną dużą litere";
                    break;
                case RegistrationMsg.AT_LEAST_ONE_LOWERCASE:
                    message = "Hasło musi zawierać co najmniej jedną małą litere";
                    break;
                case RegistrationMsg.AT_LEAST_ONE_DIGIT:
                    message = "Hasło musi zawierać co najmniej jedną cyfre";
                    break;
                case RegistrationMsg.NAME_TOO_SHORT:
                    message = "Twoje imię jest zbyt krótkie";
                    break;
                case RegistrationMsg.SURNAME_TOO_SHORT:
                    message = "Twoje nazwisko jest zbyt krótkie";
                    break;
                case RegistrationMsg.TOO_YOUNG:
                    message = "Aby się zarejestrować musisz mieć ukończone 16 lat";
                    break;
                default:
                    break;
            }

            return message;
        }
    }
}