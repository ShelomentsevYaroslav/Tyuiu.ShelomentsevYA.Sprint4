using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShelomentsevYA.Sprint4.Task2.V21.Lib
{
    public class DataService : ISprint4Task2V21
    {
        public int Calculate(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int product = 1;
            bool hasEven = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    product *= array[i];
                    hasEven = true;
                }
            }
            return hasEven ? product : 0;
        }
    }
}
