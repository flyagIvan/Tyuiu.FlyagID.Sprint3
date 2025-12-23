using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint3.Task2.V21.Lib;

namespace Tyuiu.FlyagID.Sprint3.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double x = 1.5;
            int startValue = 1;
            int stopValue = 10;

            double result = ds.GetSumSeries(x, startValue, stopValue);
            double expected = 0.298;

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
