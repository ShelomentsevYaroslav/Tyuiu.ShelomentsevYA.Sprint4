using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShelomentsevYA.Sprint4.Task1.V29.Lib
{
    public class DataService : ISprint4Task2V21
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)    
                    sum += array[i];
            }
            return sum;
        }
    }
}
