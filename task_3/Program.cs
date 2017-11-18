using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    #region *** Балеев Владимир  * Задание № 1***
    /* *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать.
     * а) с использованием методов C#
     * б) *разработав собственный алгоритм
     * Например: badc являются перестановкой abcd*/
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Comparison comparison = new Comparison(String.Format(Console.ReadLine()), String.Format(Console.ReadLine()));
            
            comparison.Anagram();
            switch (comparison.Anagram())
            {
                case 0: Console.WriteLine("Слова одинаковые");break;
                case 1: Console.WriteLine("Слова являются анаграммой."); break;
                default:
                    Console.WriteLine("Слова не являются анаграммой.");
                    break;
            }
            Console.ReadLine();
        }
    }
    /// <summary>
    /// Сравнение слов
    /// </summary>
    class Comparison
    {
        string str_1 = String.Empty, str_2 = String.Empty;

        /// <summary>
        /// </summary>
        /// <param name="str_1">Первое слово</param>
        /// <param name="str_2">Второе слово</param>
        public Comparison(string str_1, string str_2)
        {
            this.str_1 = str_1;
            this.str_2 = str_2;
        } 

        /// <summary>
        /// Метод проверки анаграммы
        /// </summary>
        /// <returns>если -1, то слова не анаграмма; если 0, то слова индентичны; 1 значит, что слова анаграмма</returns>
        public int Anagram()
        {
            int anagramResulr = -1;
            if (str_1.Length == str_2.Length)
            {
                if (String.Compare(str_1, str_2, true) == 0)
                {
                    anagramResulr = 0;
                }
                else
                {
                    char[] arrStr_1 = str_1.ToCharArray();
                    char[] arrStr_2 = str_2.ToCharArray();

                    Array.Sort(arrStr_1);
                    Array.Sort(arrStr_2);
                    
                    for (int i = 0; i < arrStr_1.Length; i++)
                    {
                        if (arrStr_1[i] != arrStr_2[i])
                        {
                            anagramResulr = -1; break;
                        }
                        anagramResulr = 1;
                    }
                }
                
            }
            return anagramResulr;
        }

    }




}
