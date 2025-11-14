using System;
using Tyuiu.ShelomentsevYA.Sprint4.Task7.V17.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint4.Task7.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Шеломенцев Я.А. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (преобразование строки в матрицу)              *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из однозначных цифр \"753159864\".                            *");
            Console.WriteLine("* Преобразуйте её в матрицу 3 на 3 и подсчитайте количество чётных чисел.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            int n = 3;
            int m = 3;
            string value = "753159864";

            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Матрица 3 x 3:");

            int index = 0;
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            DataService ds = new DataService();
            int result = ds.Calculate(n, m, value);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Количество чётных элементов матрицы: {result}");

            Console.ReadKey();
        }
    }
}
