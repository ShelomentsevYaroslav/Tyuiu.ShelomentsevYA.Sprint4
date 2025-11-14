using System;
using Tyuiu.ShelomentsevYA.Sprint4.Task4.V21.Lib;

namespace Tyuiu.ShelomemtsevYA.Sprint4.Task4.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Шеломенцев Я.А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный массив 5×5, заполненный значениями 3..8.                  *");
            Console.WriteLine("* Найти сумму чётных элементов массива.                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            int[,] matrix = new int[5, 5];

            Console.WriteLine("Введите 25 чисел массива (5 строк по 5 чисел):");

            for (int i = 0; i < 5; i++)
            {
                string[] parts = Console.ReadLine().Split(' ');
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = int.Parse(parts[j]);
                }
            }

            DataService ds = new DataService();
            int result = ds.Calculate(matrix);

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма чётных элементов: {result}");
            Console.ReadKey();
        }
    }
}
