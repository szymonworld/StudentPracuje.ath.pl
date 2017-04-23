using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracuj.Services
{
    public interface IPasswordEncryptionService
    {
        string EncryptPassword(string text);
        bool VerifyPassword(string text, string hash);
    }
}
