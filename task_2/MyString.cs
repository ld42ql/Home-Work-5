using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class MyString
    {
        string messadge = String.Empty;
        StringBuilder messResult = new StringBuilder();

        public MyString(string messadge)
        {
            this.messadge = messadge;
        }

        string[] words()
        {
            string[] words = messadge.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i];
            }
            return words;
        }

        /// <summary>
        /// Возвращение только тех слов сообщения, которые содержат не более чем n букв
        /// </summary>
        /// <param name="n">количество букв в словах</param>
        /// <returns></returns>
        public StringBuilder ShortMessadge(int n)
        {
            messResult.Clear();
            foreach (var item in words())
            {
                messResult.Append(item.Length <= n ? item + " " : " ");
            }
            
            return messResult;
        }

        /// <summary>
        /// Удаляет из сообщения все слова, которые заканчиваются на заданный символ
        /// </summary>
        /// <param name="fix">символ</param>
        /// <returns></returns>
        public StringBuilder DeleteWord(string fix)
        {
            messResult.Clear();
            foreach (var item in words())
            {
                messResult.Append(item.EndsWith(fix) ? "_ " : item + " ");
            }
            return messResult;
        }

        /// <summary>
        /// Находим самое длинное слово сообщения
        /// </summary>
        /// <returns></returns>
        public string LongWord()
        {
            string longWord = String.Empty;
            int max = int.MinValue;

            foreach (var item in words())
            {
                if (item.Length > max) { max = item.Length; longWord = item; }
            }
            return longWord;
        }

        /// <summary>
        /// Найти все самые длинные слова сообщения.
        /// </summary>
        /// <returns></returns>
        public StringBuilder ListLongWord()
        {
           int longWord = LongWord().Length;
           messResult.Clear();

            foreach (var item in words())
            {
                if (item.Length == longWord)
                {
                    messResult.Append(item + '\n');
                }
            }
            return messResult;
        }
    }
}
