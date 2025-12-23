using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint3.Task1.V18.Lib;

namespace Tyuiu.FlyagID.Sprint3.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 15;

            double result = ds.GetSumSeries(startValue, stopValue);
            double expected = 0.031;

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
