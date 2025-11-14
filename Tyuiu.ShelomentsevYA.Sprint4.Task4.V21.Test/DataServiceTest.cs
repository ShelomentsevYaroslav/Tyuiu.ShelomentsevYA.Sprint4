using Tyuiu.ShelomentsevYA.Sprint4.Task4.V21.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint4.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] matrix =
            {
                { 3, 6, 4, 6, 6 },
                { 7, 5, 5, 8, 8 },
                { 8, 3, 6, 7, 7 },
                { 5, 3, 8, 4, 5 },
                { 3, 7, 4, 3, 8 }
            };

            DataService ds = new DataService();
            int result = ds.Calculate(matrix);

            int expected = 6 + 4 + 6 + 6 + 8 + 8 + 8 + 6 + 8 + 4 + 4 + 8;
            Assert.AreEqual(expected, result);
        }
    }
}
