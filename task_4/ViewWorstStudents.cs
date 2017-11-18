using System;
using System.IO;

namespace task_4
{

    class ViewWorstStudents
    {
        string[,] students;
        byte[] minValue;
        byte count = 3; //количество минимальных балов
        string nameFile;

        public ViewWorstStudents(byte Count, string NameFile)
        {
            this.count = Count;
            this.nameFile = NameFile;
        }

        /// <summary>
        /// Открываем файл и заполняем массивы с студентами и с суммой баллов
        /// </summary>
       void OpenFile()
        {
            try
            {
                StreamReader sr = File.OpenText($"{nameFile}.txt");
                byte n = Convert.ToByte(sr.ReadLine()); // количество студентов


                students = new string[n, 3];
                minValue = new byte[n];

                for (int i = 0; i < n; i++)
                {
                    byte srValavue = 0;
                    string line = sr.ReadLine();
                    string[] fields = line.Split(' ');
                    for (int j = 0; j < 5; j++)
                    {
                        if (j < 2)
                        {
                            students[i, j] = fields[j];
                        }
                        else
                        {
                            srValavue += byte.Parse(fields[j]);
                            minValue[i] = srValavue;
                        }
                    }
                    students[i, 2] = srValavue.ToString();
                }
                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Нахождение самых плохих оценок
        /// </summary>
        /// <returns></returns>
        string[] ArrayMinValue()
        {
            OpenFile();
            Array.Sort(minValue);

            string[] min = new string[3];
            int j = 0;
            for (int i = 0; i < minValue.Length; i++)
            {
                byte tempMin = byte.MinValue;
                if (minValue[i] > tempMin)
                {
                    tempMin = minValue[i];
                    min[j] = tempMin.ToString(); j++;

                    if (i == 2)
                    {
                        break;
                    }
                }
            }
            return min;
        }

        /// <summary>
        /// Ввыводим на консоль фамилии и имена учеников по худшем трем средних баллов 
        /// </summary>
        public void ViewMinValueStudents()
        {
            OpenFile();
            for (int i = 0; i < students.GetLength(0); i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (students[i, 2].CompareTo(ArrayMinValue()[j]) == 0)
                    {
                        Console.Write($"{students[i, 0]} {students[i, 1]} - {Convert.ToDouble(students[i, 2]) / count: #.##} \n");

                    }
                }
            }
        }
    }
}
