using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    /// <summary>
    /// ПРоверка без использования регулярных выражений
    /// </summary>
    class Verification
    {
        string password;
        /// <summary>
        /// пароль на проверку
        /// </summary>
        public Verification(string Password)
        {
            this.password = Password;
        }


        char[] arrayPassword()
        {
            return password.ToCharArray();
        }

        /// <summary>
        /// Проверка по условиям: длина от двух до десяти символов; первый символ не цифра; в пароле только цифры и буквы
        /// </summary>
        /// <returns></returns>
        public bool PasswordVerification()
        {
            char[] password = arrayPassword();
            bool flag = false;


            if (password.Length >= 2 && password.Length <= 10)
            {
                if (!Char.IsDigit(password[0]))
                {
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (!char.IsLetterOrDigit(password[i]))
                        {
                            flag = false;
                            break;
                        }
                        else flag = true;
                    }
                }
            }

            return flag;
        }
    }
}
