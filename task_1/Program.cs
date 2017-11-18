using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    #region *** Балеев Владимир  * Задание № 1***
    /* Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2-х до 10-ти символов,
     * содержащая только буквы или цифры, и при этом цифра не может быть первой.
     * а) без использования регулярных выражений
     * б) **с использованием регулярных выражений*/
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Введите пароль:");
            string pass = Console.ReadLine();
            Verification user1 = new Verification(pass);
            VerificationRegex user2 = new VerificationRegex(pass);

            ViewVerification(user1.PasswordVerification());

            ViewVerification(user2.PassVerifRegul());
        }

        static void ViewVerification(bool flag)
        {
            if (flag) { Console.WriteLine("Пароль верный"); }
            else { Console.WriteLine("Пароль не верный"); }
        }
    }
}
