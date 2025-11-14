using System;
using Tyuiu.ShelomentsevYA.Sprint4.Task6.V27.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint4.Task6.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Шеломенцев Я.А. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив:                                                   *");
            Console.WriteLine("* [\"Квадрат\", \"Прямоугольник\", \"Круг\", \"Треугольник\", \"Пятиугольник\",   *");
            Console.WriteLine("*  \"Шестиугольник\", \"Восьмиугольник\"].                                   *");
            Console.WriteLine("* Используя класс Array подсчитать количество элементов, длина которых   *");
            Console.WriteLine("* меньше 7.                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            string[] shapes =
            {
                "Квадрат",
                "Прямоугольник",
                "Круг",
                "Треугольник",
                "Пятиугольник",
                "Шестиугольник",
                "Восьмиугольник"
            };

            Console.WriteLine("Исходный массив фигур:");
            foreach (string s in shapes)
            {
                Console.Write(s + "  ");
            }

            DataService ds = new DataService();
            int result = ds.Calculate(shapes);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Количество элементов с длиной меньше 7: {result}");
            Console.ReadKey();
        }
    }
}
