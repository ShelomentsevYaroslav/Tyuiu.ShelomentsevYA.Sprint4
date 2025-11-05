using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShelomentsevYA.Sprint4.Task2.V21.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint4.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate_ReturnsCorrectProduct()
        {
            var ds = new DataService();
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            int expected = 48;

            int actual = ds.Calculate(array);

            Assert.AreEqual(expected, actual);
        }

    }
}
