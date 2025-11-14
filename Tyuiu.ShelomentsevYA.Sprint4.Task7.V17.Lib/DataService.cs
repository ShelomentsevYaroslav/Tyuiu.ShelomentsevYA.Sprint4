using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShelomentsevYA.Sprint4.Task7.V17.Lib
{
    public class DataService : ISprint4Task7V17
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int index = 0;
            int countEven = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;

                    
                    if (matrix[i, j] % 2 == 0)
                    {
                        countEven++;
                    }
                }
            }

            return countEven;
        }
    }
}
