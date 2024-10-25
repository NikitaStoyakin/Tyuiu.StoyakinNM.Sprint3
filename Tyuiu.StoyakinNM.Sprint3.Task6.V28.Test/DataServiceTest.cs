using Tyuiu.StoyakinNM.Sprint3.Task6.V28.Lib;
namespace Tyuiu.StoyakinNM.Sprint3.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 13;
            int stopValue = 19;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 15;
            Assert.AreEqual(wait, res);
        }
    }
}