using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShelomentsevYA.Sprint4.Task3.V20.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint4.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            int[,] array =
            {
                { 8, 7, 7, 8, 5 },
                { 4, 3, 5, 3, 6 },
                { 5, 3, 8, 6, 3 },
                { 6, 3, 8, 5, 4 },
                { 3, 6, 8, 3, 4 }
            };

            DataService ds = new DataService();
            int res = ds.Calculate(array);

            Assert.AreEqual(3, res); 
        }
    }
}
