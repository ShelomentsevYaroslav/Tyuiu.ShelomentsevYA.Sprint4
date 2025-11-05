using System;
using Tyuiu.ShelomentsevYA.Sprint4.Task2.V21.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint4.Task2.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Шеломенцев Я.А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан массив из 15 элементов, заполненный случайными числами 1..7.        *");
            Console.WriteLine("* Найти произведение чётных элементов массива.                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            const int n = 15;
            int[] array = new int[n];
            Random rnd = new Random();

            Console.WriteLine("Сгенерированный массив:");
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(1, 8);
                Console.Write(array[i] + " ");
            }

            DataService ds = new DataService();
            int result = ds.Calculate(array);

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Произведение чётных элементов: {result}");
            Console.ReadKey();
        }
    }
}
