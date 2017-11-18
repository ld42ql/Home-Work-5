using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class VerificationRegex
    {
        string password;
        /// <summary>
        /// пароль на проверку через регулярное выражение
        /// </summary>
        public VerificationRegex(string Password)
        {
            this.password = Password;
        }

        Regex passRegex = new Regex(@"^[a-zA-Z][a-zA-Z0-9]{2,9}$");

       public bool PassVerifRegul()
        {
            bool flag = false;

            if (passRegex.Match(password).Success) {flag = true;}

            return flag;
        }

    }
}
