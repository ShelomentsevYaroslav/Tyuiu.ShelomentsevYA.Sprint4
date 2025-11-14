using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShelomentsevYA.Sprint4.Task3.V20.Lib
{
    public class DataService : ISprint4Task3V20
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);

            int min = array[0, 0]; 

            for (int i = 1; i < rows; i++)
            {
                if (array[i, 0] < min)
                {
                    min = array[i, 0];
                }
            }

            return min;
        }
    }
}
