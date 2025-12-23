using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint3.Task5.V18.Lib;

namespace Tyuiu.FlyagID.Sprint3.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = -1;
            int stopValue1 = -1;
            int startValue2 = 1;
            int stopValue2 = 1;

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double expected = Math.Round(Math.Cos(5) + 0.5, 3);

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
