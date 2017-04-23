using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracuj.Services
{
    public class PasswordEncryptionService : IPasswordEncryptionService
    {
        public string EncryptPassword(string text)
        {
            return BCrypt.Net.BCrypt.HashPassword(text, BCrypt.Net.BCrypt.GenerateSalt());
        }

        public bool VerifyPassword(string text, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(text, hash);
        }
    }
}
