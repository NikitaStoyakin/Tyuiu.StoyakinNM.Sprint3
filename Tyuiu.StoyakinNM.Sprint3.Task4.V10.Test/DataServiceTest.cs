using Tyuiu.StoyakinNM.Sprint3.Task4.V10.Lib;
namespace Tyuiu.StoyakinNM.Sprint3.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int StartValue = -5;
            int StopValue = 5;

            double res = ds.Calculate(StartValue, StopValue);

            double wait = 0.014;
            Assert.AreEqual(wait, res);
        }
    }
}