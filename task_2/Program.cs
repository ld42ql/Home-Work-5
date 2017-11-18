using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    #region *** Балеев Владимир  * Задание № 1***
    /* Разработать методы для решения следующих задач. Дано сообщение:
     * а) Вывести только те слова сообщения, которые содержат не более чем n букв;
     * б) Удалить из сообщения все слова, которые заканчиваются на заданный символ;
     * в) Найти самое длинное слово сообщения;
     * г) Найти все самые длинные слова сообщения.
     * Постараться разработать класс MyString.*/
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = File.OpenText(@"Text.txt");
            string text = sr.ReadToEnd();

            Console.WriteLine($"{text}");

            MyString myString = new MyString(text);

            Console.WriteLine();

            Console.WriteLine($"{myString.ShortMessadge(6)}");

            Console.WriteLine();

            Console.WriteLine($"{myString.DeleteWord("я")}");

            Console.WriteLine();

            Console.WriteLine($"{myString.LongWord()}");

            Console.WriteLine();

            Console.WriteLine($"{myString.ListLongWord()}");

            Console.ReadKey();
        }
    }
}
