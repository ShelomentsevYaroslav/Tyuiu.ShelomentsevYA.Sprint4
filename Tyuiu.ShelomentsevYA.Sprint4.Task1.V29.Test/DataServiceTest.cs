using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShelomentsevYA.Sprint4.Task1.V29.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint4.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_SumOdd_Ok()
        {
            var ds = new DataService();
            int[] arr = { 5, 3, 3, 4, 1, 3, 3, 5, 6, 2, 7, 2, 1, 8 };
            int expected = 31; 
            int actual = ds.Calculate(arr);
            Assert.AreEqual(expected, actual);
        }
    }
}
