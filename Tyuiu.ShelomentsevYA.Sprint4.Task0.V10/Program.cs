using System;
using Tyuiu.ShelomentsevYA.Sprint4.Task0.V10.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint4.Task0.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Шеломенцев Я.А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан массив из 10 элементов. Подсчитать сумму нечетных элементов массива *");
            Console.WriteLine("* Массив: { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 }                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };
            var ds = new DataService();
            int sum = ds.GetSumOddArrEl(array);

            Console.WriteLine(sum); 
            Console.ReadKey();
        }
    }
}
