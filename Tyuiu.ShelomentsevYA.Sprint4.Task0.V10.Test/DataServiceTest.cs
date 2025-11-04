using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShelomentsevYA.Sprint4.Task0.V10.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint4.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumOddArrEl_Returns43_ForGivenArray()
        {
            var ds = new DataService();
            int[] arr = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };

            int actual = ds.GetSumOddArrEl(arr);

            Assert.AreEqual(43, actual);
        }
    }
}
