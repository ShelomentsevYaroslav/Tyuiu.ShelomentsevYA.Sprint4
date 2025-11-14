using Tyuiu.ShelomentsevYA.Sprint4.Task6.V27.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint4.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] shapes =
            {
                "Квадрат",
                "Прямоугольник",
                "Круг",
                "Треугольник",
                "Пятиугольник",
                "Шестиугольник",
                "Восьмиугольник"
            };

            DataService ds = new DataService();

            
            int result = ds.Calculate(shapes);

            
            int expected = 1;
            Assert.AreEqual(expected, result);
        }
    }
}
