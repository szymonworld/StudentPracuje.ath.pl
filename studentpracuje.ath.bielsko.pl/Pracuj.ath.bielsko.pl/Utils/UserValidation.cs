using Pracuj.Models;
using Pracuj.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pracuj.ath.bielsko.pl.Utils
{

    public enum RegistrationMsg
    {
        OK,
        NULL,
        PASSWORD_TOO_SHORT,
        LOGIN_TOO_SHORT,
        INVALID_EMAIL,
        LOGIN_ALREADY_EXIST,
        AT_LEAST_ONE_UPPERCASE,
        AT_LEAST_ONE_LOWERCASE,
        AT_LEAST_ONE_DIGIT,
        NAME_TOO_SHORT,
        SURNAME_TOO_SHORT,
        TOO_YOUNG,

    }


    public class UserValidation
    {
        private User _user;
        private IRepositoryService<User> _users;

        public UserValidation(User user, IRepositoryService<User> users)
        {
            _user = user;
            _users = users;
        }

        public RegistrationMsg Validate()
        {

            if (_user.Login.Count() < 5)
                return RegistrationMsg.LOGIN_TOO_SHORT;

            if (_users.FindBy(x => x.Login == _user.Login).Count() > 0)
                return RegistrationMsg.LOGIN_ALREADY_EXIST;

            RegistrationMsg msg = ValidatePassword(_user.Password);

            if (msg != RegistrationMsg.OK)
                return msg;

            if(!new EmailAddressAttribute().IsValid(_user.Email))
                return RegistrationMsg.INVALID_EMAIL;

            if(_user.Name.Length < 1)
                return RegistrationMsg.NAME_TOO_SHORT;

            if (_user.Surname.Length < 1)
                return RegistrationMsg.SURNAME_TOO_SHORT;

            if (_user.BirthDate.AddYears(16) < DateTime.Now)
                return RegistrationMsg.TOO_YOUNG;

            return RegistrationMsg.OK;

        }
        private RegistrationMsg ValidatePassword(string password)
        {
            const int MIN = 8;
            const int MAX = 32;

            if (password == null) return RegistrationMsg.NULL;

            bool lengthR = password.Length >= MIN && password.Length <= MAX;
            bool upperR = false;
            bool lowerR = false;
            bool digitR = false;

            if (lengthR)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) upperR = true;
                    else if (char.IsLower(c)) lowerR = true;
                    else if (char.IsDigit(c)) digitR = true;
                }
            }

            if (!lengthR)
                return RegistrationMsg.PASSWORD_TOO_SHORT;
            else if (!upperR)
                return RegistrationMsg.AT_LEAST_ONE_UPPERCASE;
            else if (!lowerR)
                return RegistrationMsg.AT_LEAST_ONE_LOWERCASE;
            else if (!digitR)
                return RegistrationMsg.AT_LEAST_ONE_DIGIT;

            return RegistrationMsg.OK;

        }

    }
}