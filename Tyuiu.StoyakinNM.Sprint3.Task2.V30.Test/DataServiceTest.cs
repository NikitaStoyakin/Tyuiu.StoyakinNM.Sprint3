using Tyuiu.StoyakinNM.Sprint3.Task2.V30.Lib;
namespace Tyuiu.StoyakinNM.Sprint3.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 11;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 13051.34;

            Assert.AreEqual(wait, res);
        }
    }
}