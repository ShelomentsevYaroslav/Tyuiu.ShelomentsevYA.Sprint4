using Tyuiu.ShelomentsevYA.Sprint4.Task5.V21.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint4.Task5.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] matrix =
            {
                { -8,  0,  2 },
                {  1, -3,  2 },
                {  0, -1, -8 }
            };

            int[,] expected =
            {
                { -8,  0,  1 },
                {  1, -3,  1 },
                {  0, -1, -8 }
            };

            DataService ds = new DataService();
            int[,] actual = ds.Calculate(matrix);

            int rows = expected.GetLength(0);
            int cols = expected.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
            }
        }
    }
}
