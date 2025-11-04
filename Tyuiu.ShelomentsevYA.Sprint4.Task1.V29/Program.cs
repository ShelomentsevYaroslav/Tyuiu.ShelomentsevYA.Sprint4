using System;
using Tyuiu.ShelomentsevYA.Sprint4.Task1.V29.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint4.Task1.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Шеломенцев Я.А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Шеломенцев Я.А. | ИСТНб-25-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан массив из 14 целых чисел (1..9). Подсчитать сумму нечётных элементов*");
            Console.WriteLine("***************************************************************************\n");

            const int n = 14;
            int[] arr = new int[n];

            Console.WriteLine("Введите 14 целых чисел через Enter (1..9).");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"[{i + 1}/{n}] = ");

                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.Write("Некорректно. Повторите ввод: ");
                }
            }

            var ds = new DataService();
            int result = ds.Calculate(arr);

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
