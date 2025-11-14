using Tyuiu.ShelomentsevYA.Sprint4.Task5.V21.Lib;
using System;
namespace Tyuiu.ShelomemtsevYA.Sprint4.Task5.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Шеломенцев Я.А. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                     *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный       *");
            Console.WriteLine("* случайными значениями в диапазоне от -8 до 2.                          *");
            Console.WriteLine("* Заменить положительные элементы на 1.                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            const int rows = 5;
            const int cols = 5;
            int[,] matrix = new int[rows, cols];

            Random rnd = new Random();

            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rnd.Next(-8, 3); 
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }

            DataService ds = new DataService();
            int[,] result = ds.Calculate(matrix);

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Матрица после замены положительных элементов на 1:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(result[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
