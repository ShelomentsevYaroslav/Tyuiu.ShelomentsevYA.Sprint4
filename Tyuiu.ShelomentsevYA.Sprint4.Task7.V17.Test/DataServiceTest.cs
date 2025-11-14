using Tyuiu.ShelomentsevYA.Sprint4.Task7.V17.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint4.Task7.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 3;
            string value = "753159864";

            
            int res = ds.Calculate(n, m, value);

            
            Assert.AreEqual(3, res);   
        }
    }
}
