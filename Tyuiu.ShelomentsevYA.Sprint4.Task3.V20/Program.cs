using System;
using Tyuiu.ShelomentsevYA.Sprint4.Task3.V20.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint4.Task3.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Шеломенцев Я.А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный массив 5 на 5, заполненный числами 3..8.                  *");
            Console.WriteLine("* Найти минимальный элемент первого столбца.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            int[,] array =
            {
                { 8, 7, 7, 8, 5 },
                { 4, 3, 5, 3, 6 },
                { 5, 3, 8, 6, 3 },
                { 6, 3, 8, 5, 4 },
                { 3, 6, 8, 3, 4 }
            };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Минимальный элемент первого столбца: {result}");
            Console.ReadKey();
        }
    }
}
